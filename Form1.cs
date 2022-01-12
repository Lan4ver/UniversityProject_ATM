using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaksymPodorozhnyi_50402_ProjektNr1
{
    public partial class Form1 : Form
    {
        double[] mPCoins = { 2, 0.5, 0.2, 0.1 };
        double[] mPBanknots = { 200, 100, 50, 20, 10, 5 };
        double[] mPTotalBanknots;

        public Form1()
        {
            InitializeComponent();
            mPTotalBanknots = mPBanknots.Concat(mPCoins).ToArray();
        }

        private List<Transaction> CalculateTransaction(double mPsum, List<double> banknots)
        {
            var mPlist = new List<Transaction>();
            var mPDone = true;
            while (mPDone)
            {
                if (banknots.Count == 0)
                {
                    mPDone = false;
                    break;
                }

                var maxBanknot = banknots.Max();
                if (mPsum - maxBanknot >= 0 && banknots.Count > 0)
                {
                    mPsum -= maxBanknot;
                    if (mPlist.Count > 0 && mPlist.Any((x) => x.mPBanknot == maxBanknot))
                    {
                        var item = mPlist.First(x => x.mPBanknot == maxBanknot);
                        item.mPCount++;
                    }
                    else
                        mPlist.Add(new Transaction { mPBanknot = maxBanknot, mPCount = 1, mPCurrency = this.cmbWalut.GetItemText(this.cmbWalut.SelectedItem) });
                }
                else if (mPsum - maxBanknot < 0 && banknots.Count > 0)
                {
                    banknots.Remove(maxBanknot);
                }
            }
            return mPlist;
        }

        private void ShowError()
        {
            MessageBox.Show("ERROR");
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cmbWalut.SelectedIndex == -1)
            {
                ShowError();
                return;
            }

            var mPmaxBorder = 200.0;
            var mPminBorder = 0.0;
            if (rdbCustom.Checked)
            {
                if (!double.TryParse(txtMax.Text, out mPmaxBorder))
                {
                    ShowError();
                    return;
                }
                if (!double.TryParse(txtMin.Text, out mPminBorder))
                {
                    ShowError();
                    return;
                }
            }

            double Sum;
            if (!double.TryParse(txtMoneyToGet.Text, out Sum))
            {
                ShowError();
                return;
            }

            var availableBanknots = GetAvailableBanknots(mPminBorder, mPmaxBorder);

            var transactions = CalculateTransaction(Sum, availableBanknots);

            ShowTransactions(transactions);

            GiveMoney(transactions);
        }

        private void GiveMoney(List<Transaction> transactions)
        {
            txtMoneyGet.Text = transactions.Sum(x => x.mPBanknot * x.mPCount).ToString();
        }
        ///
        private List<double> GetAvailableBanknots(double min, double max)
        {
            var maxBanknot = mPTotalBanknots.Aggregate((x, y) => Math.Abs(x - max) < Math.Abs(y - max) ? x : y);
            var minBanknot = mPTotalBanknots.Aggregate((x, y) => Math.Abs(x - min) < Math.Abs(y - min) ? x : y);
            return mPTotalBanknots.Where((x) => x >= minBanknot && x <= maxBanknot).ToList();
        }
        ///
        private void ShowTransactions(List<Transaction> transactions)
        {
            foreach (var item in transactions)
            {
                var currencyType = GetCurrencyType(item);
                dgvPaymentList.Rows.Add(item.mPCount, item.mPBanknot, currencyType, item.mPCurrency);
            }
        }

        private string GetCurrencyType(Transaction item)
        {
            if (mPCoins.Contains(item.mPBanknot))
                return "Groszy";
            return "Gotówka";
        }

        private void btnKoniec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMax.Text = string.Empty;
            txtMin.Text = string.Empty;
            txtMoneyToGet.Text = string.Empty;
            txtMoneyGet.Text = string.Empty;
            dgvPaymentList.Rows.Clear();
        }

        private void rdbCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCustom.Checked)
            {
                label5.Visible = true;
                txtMax.Visible = true;
                label6.Visible = true;
                txtMin.Visible = true;
            }
            else
            {
                label5.Visible = false;
                txtMax.Visible = false;
                label6.Visible = false;
                txtMin.Visible = false;
            }
        }
    }
}
