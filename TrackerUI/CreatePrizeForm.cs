﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel
                    (placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }

                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This Form has invalid information. Please check it and try again");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);
            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            output = NotTrue(!placeNumberValidNumber, output);
            output = NotTrue(placeNumber < 1, output);
            output = NotTrue(placeNameValue.Text.Length == 0, output);
            output = NotTrue(!prizeAmountValid || !prizePercentageValid, output);
            output = NotTrue(prizeAmount <= 0 && prizePercentage <= 0, output);
            output = NotTrue(prizePercentage < 0 || prizePercentage > 100, output);

            return output;
        }

        private static bool NotTrue(bool input, bool output)
        {
            if (input)
            {
                return false;
            }

            return output;
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
