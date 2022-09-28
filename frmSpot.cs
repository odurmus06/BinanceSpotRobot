using Binance.Net;
using Binance.Net.Clients;
using Binance.Net.Objects;
using CryptoExchange.Net.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BinanceSpotRobot
{
    public partial class frmSpot : Form
    {
        BinanceClient client;
        decimal minQty = 0;
        decimal maxQty = 0;
        decimal stepSize = 0;
        decimal tickSize = 0;
        int quotePrecision = 0;
        int baseAssetPrecision = 0;
        string symbol = "";

        decimal m_Price = 0;
        decimal m_LongPrice = 0;

        //cüzdan
        decimal m_LastBalance = 0;

        //Flags
        bool iseditable = true;

        //son alış
        decimal m_buy_price = 0;
        decimal m_buy_quantity = 0;

        decimal maker = 0.1m;
        decimal taker = 0.1m;

        int count = 13;

        bool alis_emri = false, satis_emri = false;

        [DllImport("user32.dll")]
        private static extern bool EnumThreadWindows(uint dwThreadId, EnumThreadDelegate lpfn, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("User32", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(IntPtr windowHandle, StringBuilder stringBuilder, int nMaxCount);

        [DllImport("user32.dll", EntryPoint = "GetWindowTextLength", SetLastError = true)]
        internal static extern int GetWindowTextLength(IntPtr hwnd);

        private static List<IntPtr> windowList;
        private static string _className;
        private static StringBuilder apiResult = new StringBuilder(256); //256 Is max class name length.
        private delegate bool EnumThreadDelegate(IntPtr hWnd, IntPtr lParam);

        BinanceSocketClient sclient = new BinanceSocketClient();
        BinanceSocketClient socketClient = new BinanceSocketClient();
        public frmSpot()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Symbol";
            dataGridView1.Columns[1].Name = "Miktar";

            dg_emirler.ColumnCount = 4;
            dg_emirler.Columns[0].Name = "orderid";
            dg_emirler.Columns[1].Name = "symbol";
            dg_emirler.Columns[2].Name = "side";
            dg_emirler.Columns[3].Name = "price";
            dg_emirler.AllowUserToAddRows = false;

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 83;
            dataGridView1.AllowUserToAddRows = false;

            for (int i = 0; i < count; i++)
            {
                dataGridView1.Rows.Add("");
            }

            CheckForIllegalCrossThreadCalls = false;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            CultureInfo ci = new CultureInfo("en-US", false);
            Thread.CurrentThread.CurrentCulture = ci;

            dataGridView1.SetDoubleBuffering(true);
            dataGridView1.BeginInit();
            dataGridView1.SetRedraw(true);
            client = new BinanceClient(new BinanceClientOptions()
            {
                ApiCredentials = new ApiCredentials("W2xDrl2vqZO0wL44QWvGCHoUJmVtR3KCw6o7Bau1eCuoI4KwHT4unFvS6ec3nhWO", "1c3EwSnJCCjH5NmKfMtcQyvdvQn6TF5vn5T9z51SvrWmWFxGaZr1Hucaguq338uF")
            });

            lbl_cuzdan.Text = cuzdan().ToString();


            Task.Run(async () => await start());
            Task.Run(async () => await title());
            Task.Run(async () => await updated());
        }

        async Task start()
        {
            while (true)
            {
                var data = client.SpotApi.ExchangeData.GetTickersAsync().Result.Data;

                var symbolStatistics = data.Where(x => x.Symbol.EndsWith("USDT")).Where(x => x.Symbol.EndsWith("DOWNUSDT") == false).Where(x => x.Symbol.EndsWith("UPUSDT") == false).ToList();

                var orderByDescendingResult = (from s in symbolStatistics
                                               orderby s.PriceChangePercent descending
                                               select s).Take(count);
                int index = 0;
                foreach (var item in orderByDescendingResult)
                {
                    dataGridView1.Rows[index].Cells[0].Value = item.Symbol;
                    dataGridView1.Rows[index].Cells[1].Value = item.PriceChangePercent;
                    index++;
                }
                await Task.Delay(60000);
            }
        }
        decimal cuzdan()
        {
            m_LastBalance = client.SpotApi.Account.GetAccountInfoAsync().Result.Data.Balances.Where(c => c.Asset == "USDT").Select(c => c.Available).First();

            return m_LastBalance;

        }
        public static decimal Fee(decimal order)
        {
            return order / 100 * 0.1m;
        }
        async Task title()
        {
            while (true)
            {
                if (chk_lissen.Checked)
                {
                    List<IntPtr> ChromeWindows = WindowsFinder("Chrome_WidgetWin_1", "chrome");
                    foreach (IntPtr windowHandle in ChromeWindows)
                    {
                        int length = GetWindowTextLength(windowHandle);
                        StringBuilder sb = new StringBuilder(length + 1);
                        GetWindowText(windowHandle, sb, sb.Capacity);

                        string m_title = sb.ToString();

                        if (m_title.Split(' ').Length >= 2)
                        {
                            decimal oReturn = 0;

                            string temp_price = m_title.Split(' ')[1];
                            string temp_symbol = m_title.Split(' ')[0];
                            bool isNumeric = decimal.TryParse(temp_price, out oReturn);

                            if (isNumeric)
                            {
                                if (temp_symbol != symbol && temp_symbol.EndsWith("USDT"))
                                {
                                    pc_image.ImageLocation = "https://www.gate.io/images/coin_icon/64/" + temp_symbol.Replace("USDT", "").ToLower(new CultureInfo("en-US")) + ".png";
                                    var ExchangeInfo = client.SpotApi.ExchangeData.GetExchangeInfoAsync().Result.Data.Symbols.Where(c => c.Name == temp_symbol);

                                    tickSize = ExchangeInfo.Select(c => c.PriceFilter.TickSize).First();
                                    stepSize = ExchangeInfo.Select(c => c.LotSizeFilter.StepSize).First();
                                    minQty = ExchangeInfo.Select(c => c.LotSizeFilter.MinQuantity).First();
                                    maxQty = ExchangeInfo.Select(c => c.LotSizeFilter.MaxQuantity).First();
                                    quotePrecision = ExchangeInfo.Select(c => c.QuoteAssetPrecision).First();
                                    baseAssetPrecision = ExchangeInfo.Select(c => c.BaseAssetPrecision).First();
                                    m_buy_price = 0;
                                    m_buy_quantity = 0;

                                     getopenOrders(temp_symbol);
                                     getLastOrders(temp_symbol, Convert.ToDecimal(temp_price, new CultureInfo("en-US")));
                                }

                                symbol = temp_symbol;
                                lbl_symbol.Text = symbol;
                                if (iseditable)
                                {
                                    try
                                    {
                                        m_Price = Convert.ToDecimal(temp_price, new CultureInfo("en-US"));

                                        m_Price = priceformat(m_Price);

                                        m_LongPrice = priceformat((m_Price) + ((m_Price / 100) * Convert.ToDecimal(txt_tp.Text, new CultureInfo("en-US"))));

                                        decimal m_Total = Convert.ToDecimal(txt_miktar.Text, new CultureInfo("en-US"));
                                        decimal t_Total = m_Total;

                                        m_Total = m_LastBalance;

                                        if (t_Total > 0 && t_Total < m_Total)
                                            m_Total = t_Total;

                                        lbl_k_z.Text = karzarar(m_Price, m_LongPrice, m_Total).ToString("N2");

                                        if (m_buy_price != 0 || m_buy_quantity != 0)
                                            lbl_satis_kar.Text = karzarar(m_buy_price, m_Price, m_buy_quantity).ToString("N2");
                                        else
                                            lbl_satis_kar.Text = "";

                                        lbl_price.Text = m_Price.ToString();

                                    }
                                    catch
                                    {

                                    }
                                }
                            }
                        }
                    }
                }

                await Task.Delay(1);
            }
        }
        private static List<IntPtr> WindowsFinder(string className, string process)
        {
            _className = className;
            windowList = new List<IntPtr>();

            Process[] chromeList = Process.GetProcessesByName(process);

            if (chromeList.Length > 0)
            {
                foreach (Process chrome in chromeList)
                {
                    if (chrome.MainWindowHandle != IntPtr.Zero)
                    {
                        foreach (ProcessThread thread in chrome.Threads)
                        {
                            EnumThreadWindows((uint)thread.Id, new EnumThreadDelegate(EnumThreadCallback), IntPtr.Zero);
                        }
                    }
                }
            }

            return windowList;
        }

        static bool EnumThreadCallback(IntPtr hWnd, IntPtr lParam)
        {
            if (GetClassName(hWnd, apiResult, apiResult.Capacity) != 0)
            {
                if (string.CompareOrdinal(apiResult.ToString(), _className) == 0)
                {
                    windowList.Add(hWnd);
                }
            }
            return true;
        }
        public decimal karzarar(decimal tl_alis, decimal tl_satis, decimal tl)
        {
            decimal sonuc = 0;

            decimal tl_input = tl;

            decimal yuzde_alis = maker;

            decimal yuzde_satis = taker;

            decimal alinan_miktar = (tl_input) / tl_alis;

            var hesaplanan_alis_komisyon = (alinan_miktar * yuzde_alis) / 100;

            var satis = (alinan_miktar - hesaplanan_alis_komisyon) * tl_satis;

            var hesaplanan_satis_komisyon = (satis * yuzde_satis) / 100;

            var tl_komisyon = hesaplanan_satis_komisyon;

            sonuc = (satis - tl_komisyon) - tl_input;

            if (sonuc > 0)
                lbl_satis_kar.ForeColor = Color.Green;
            else if (sonuc < 0)
                lbl_satis_kar.ForeColor = Color.Red;
            else
                lbl_satis_kar.ForeColor = Color.Black;

            return sonuc;
        }
        async Task getLastOrders(string symbol, decimal temp_price)
        {
            var details = client.SpotApi.Trading.GetOrdersAsync(symbol).Result.Data.Where(c => c.Side == Binance.Net.Enums.OrderSide.Buy).Where(c => c.Status == Binance.Net.Enums.OrderStatus.Filled).ToList();

            m_buy_price = priceformat(details[details.Count - 1].Price);
            m_buy_quantity = details[details.Count - 1].QuantityFilled * m_buy_price;

            decimal amount = client.SpotApi.Account.GetAccountInfoAsync().Result.Data.Balances.Where(c => c.Asset == symbol.Replace("USDT", "")).Select(c => c.Total).First();

            amount = Helpers.ClampQuantity(minQty, maxQty, stepSize, amount);

            if ((amount * temp_price) < 5)
            {
                m_buy_price = 0;
                m_buy_quantity = 0;
            }
           
        }

        async Task getopenOrders(string symbol)
        {
            dg_emirler.Rows.Clear();
          var get = client.SpotApi.Trading.GetOpenOrdersAsync(symbol).Result.Data.ToList();

            //foreach (var item in get)
            //{
            //    delete(item.Id.ToString());
            //    dg_emirler.Rows.Add(item.Id.ToString(), item.Symbol, item.Side, item.Price);
            //}

        }
        decimal priceformat(decimal price)
        {

            price = Helpers.FloorPrice(tickSize, price);
            return price;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string coin = row.Cells[0].Value.ToString();
                string url = "https://tradingview.com/chart/Z2Q0Lbue/?symbol=BINANCE:" + coin.ToLower(new CultureInfo("en-US", false));
                Process.Start("chrome.exe", url);

            }
        }
        void delete(string orderid)
        {
            int index = getindex(orderid);

            if (index >= 0)
            {
                dg_emirler.Rows.RemoveAt(index);
            }
        }
        int getindex(string orderid)
        {
            int sonuc = -1;
            int sayac = 0;
            foreach (DataGridViewRow row in dg_emirler.Rows)
            {
                string coin = row.Cells[0].Value.ToString();

                if (coin == orderid)
                {
                    sonuc = sayac;
                    break;
                }
                sayac++;
            }
            return sonuc;
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {

        }

        private void frmSpot_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                chk_lissen.Checked = false;
            }
        }

        private void btn_long_Click(object sender, EventArgs e)
        {
           
            Task.Run(async () => await DOBUY());
        }

        private void btn_short_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await DOSELL(m_Price));
        }

        private void chk_topmost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chk_topmost.Checked;
        }
        async Task DOBUY()
        {
            decimal m_Total = Convert.ToDecimal(txt_miktar.Text, new CultureInfo("en-US"));
            decimal t_Total = m_Total;

            m_Total = cuzdan();
            m_Total = Math.Floor(m_Total);

            if (t_Total > 0 && t_Total < m_Total)
                m_Total = t_Total;

            decimal amount = (m_Total / m_Price);
            amount = amount - Fee(amount);
            amount = Helpers.ClampQuantity(minQty, maxQty, stepSize, amount);


            var execute = client.SpotApi.Trading.PlaceOrderAsync(symbol, Binance.Net.Enums.OrderSide.Buy, Binance.Net.Enums.SpotOrderType.Market, amount).Result;

            if (!execute.Success)
            {
                txt_log.Text += execute.Error.Message;
            }
            else
            {
                alis_emri = true;
            }



        }
        async Task DOSELL(decimal price)
        {
            decimal amount = client.SpotApi.Account.GetAccountInfoAsync().Result.Data.Balances.Where(c => c.Asset == symbol.Replace("USDT", "")).Select(c => c.Available).First();

            amount = amount - Fee(amount);
            amount = Helpers.ClampQuantity(minQty, maxQty, stepSize, amount);


            var execute = client.SpotApi.Trading.PlaceOrderAsync(symbol, Binance.Net.Enums.OrderSide.Sell, Binance.Net.Enums.SpotOrderType.Limit, amount, price: price, timeInForce: Binance.Net.Enums.TimeInForce.GoodTillCanceled).Result;

            if (!execute.Success)
            {
                txt_log.Text += execute.Error.Message;
            }
            else
            {
                satis_emri = true;
            }

        }

        async Task updated()
        {
            while (true)
            {
                if (alis_emri == true || satis_emri == true)
                {
                    var get = client.SpotApi.Trading.GetOrdersAsync(symbol).Result.Data.ToList();


                    if (get.Count > 0)
                    {
                        var data = get[get.Count - 1];

                        if (data.Status == Binance.Net.Enums.OrderStatus.Canceled)
                        {
                            delete(data.Id.ToString());
                            alis_emri = false;
                            satis_emri = false;
                        }
                        else if (data.Status == Binance.Net.Enums.OrderStatus.New)
                        {
                            delete(data.Id.ToString());
                            dg_emirler.Rows.Add(data.Id.ToString(), data.Symbol, data.Side, data.Price);
                        }
                        else if (data.Status == Binance.Net.Enums.OrderStatus.Filled && data.Side == Binance.Net.Enums.OrderSide.Buy)
                        {
                            alis_emri = false;
                            delete(data.Id.ToString());
                            m_buy_price = data.Price;
                            m_buy_quantity = data.QuoteQuantityFilled;
                            if (chk_kar_al.Checked)
                            {
                                DOSELL(priceformat((data.Price) + ((data.Price / 100) * Convert.ToDecimal(txt_tp.Text, new CultureInfo("en-US")))));
                            }
                        }
                        else if (data.Status == Binance.Net.Enums.OrderStatus.Filled && data.Side == Binance.Net.Enums.OrderSide.Sell)
                        {
                            satis_emri = false;
                            delete(data.Id.ToString());
                            m_buy_price = 0;
                            m_buy_quantity = 0;
                        }
                        else
                        {
                            alis_emri = false;
                            satis_emri = false;
                            delete(data.Id.ToString());
                        }
                    }
                }
                await Task.Delay(2000);
            }

        }

        public static decimal validAmount(decimal ticker, decimal fiat, decimal step, decimal min, decimal max)
        {
            //ticker example: 1 holo = 0.07289000
            //fiat example: want to buy holo with 500 dollars.
            //step example: https://api.binance.com/api/v3/exchangeInfo?symbol=BTCTRY  => stepSize
            //min example: https://api.binance.com/api/v3/exchangeInfo?symbol=BTCTRY  => minQty
            //max example: https://api.binance.com/api/v3/exchangeInfo?symbol=BTCTRY  => maxQty


            decimal oldAmount = 0;
            decimal amount = fiat / ticker;
            oldAmount = amount;
            amount = ((Math.Round(amount / step)) * step);

            if (oldAmount < amount)
            {
                amount = amount - step;
            }

            if (amount > min && amount < max)
                return 0;

            return amount;

        }
       

        //async Task updated()
        //{


        //    var listenKey = await client.SpotApi.Account.StartUserStreamAsync();
        //    if (!listenKey.Success)
        //    {
        //        // Handler failure
        //        return;
        //    }
        //    var sub = await socketClient.SpotStreams.SubscribeToUserDataUpdatesAsync(listenKey.Data,
        //        data =>
        //        {

        //            if (data.Data.Status == Binance.Net.Enums.OrderStatus.Canceled)
        //            {
        //                delete(data.Data.Id.ToString());
        //            }
        //            else if (data.Data.Status == Binance.Net.Enums.OrderStatus.New)
        //            {
        //                delete(data.Data.Id.ToString());
        //                dg_emirler.Rows.Add(data.Data.Id.ToString(), data.Data.Symbol, data.Data.Side, data.Data.Price);
        //            }
        //            else if (data.Data.Status == Binance.Net.Enums.OrderStatus.Filled && data.Data.Side == Binance.Net.Enums.OrderSide.Buy)
        //            {
        //                delete(data.Data.Id.ToString());

        //                var dda = data.Data;

        //                m_buy_price = data.Data.LastPriceFilled;
        //                m_buy_quantity = data.Data.QuoteQuantityFilled;
        //                if (chk_kar_al.Checked)
        //                {
        //                    DOSELL(priceformat((data.Data.LastPriceFilled) + ((data.Data.LastPriceFilled / 100) * Convert.ToDecimal(txt_tp.Text, new CultureInfo("en-US")))));
        //                }
        //            }
        //            else if (data.Data.Status == Binance.Net.Enums.OrderStatus.Filled && data.Data.Side == Binance.Net.Enums.OrderSide.Sell)
        //            {
        //                delete(data.Data.Id.ToString());
        //                m_buy_price = 0;
        //                m_buy_quantity = 0;
        //            }
        //            else
        //            {
        //                delete(data.Data.Id.ToString());
        //            }
        //        },
        //        data =>
        //        {
        //            // Handle oco order update
        //        },
        //        data =>
        //        {
        //            // Handle account balance update, caused by trading
        //            var balance = data.Data.Balances.Where(c => c.Asset == "USDT").Select(c => c.Available).First();
        //            m_LastBalance = balance;
        //            lbl_cuzdan.Text = balance.ToString();
        //        },
        //        data =>
        //        {
        //            // Handle account balance update, caused by withdrawal/deposit or transfers

        //        });
        //}
    }
}
