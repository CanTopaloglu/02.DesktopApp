﻿using Azure.Core;
using Iyzipay.Model;
using Microsoft.IdentityModel.Abstractions;
using MyRestaurantApp.Context;
using MyRestaurantApp.DTOs;
using MyRestaurantApp.Models;

namespace MyRestaurantApp;
public partial class FrmPayment : Form
{
    private readonly FrmAddition _frmAddition;
    public FrmPayment(string total, FrmAddition frmAddition)
    {
        InitializeComponent();
        lbTotal.Text = total;
        _frmAddition = frmAddition;
        ////this.Size = new System.Drawing.Size(409, 701);
        ////this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y + 160);
    }


    private void cbCC_CheckedChanged(object sender, EventArgs e)
    {
        if (cbCC.Checked)
        {
            gbCC.Visible = true;
            btnMakeThePayment.Location = new System.Drawing.Point(18, 600);
            gbCC.Location = new System.Drawing.Point(18, 194);
            this.Size = new System.Drawing.Size(409, 701);
            this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y - 160);
        }
        else
        {
            gbCC.Visible = false;
            btnMakeThePayment.Location = new System.Drawing.Point(18, 194);
            this.Size = new System.Drawing.Size(409, 285);
            this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y + 160);
        }

    }

    private void btnMakeThePayment_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtCash.Text)) txtCash.Text = "0";
        if (string.IsNullOrEmpty(txtCC.Text)) txtCC.Text = "0";

        PaymentCard paymentCard = new()
        {
            CardHolderName = txtCCOwner.Text,
            CardNumber = txtCCNumber1.Text + txtCCNumber2.Text + txtCCNumber3.Text + txtCCNumber4.Text,
            Cvc = txtCVC.Text,
            ExpireMonth = txtExpireMonth.Text,
            ExpireYear = txtExpireYear.Text,
            RegisterCard = 0
        };

        Buyer buyer = new Buyer();
        buyer.Id = "BY789";
        buyer.Name = "John";
        buyer.Surname = "Doe";
        buyer.GsmNumber = "+905350000000";
        buyer.Email = "email@email.com";
        buyer.IdentityNumber = "74300864791";
        buyer.LastLoginDate = "2015-10-05 12:43:35";
        buyer.RegistrationDate = "2013-04-21 15:12:09";
        buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
        buyer.Ip = "85.34.78.112";
        buyer.City = "Istanbul";
        buyer.Country = "Turkey";
        buyer.ZipCode = "34732";

        Address shippingAddress = new Address();
        shippingAddress.ContactName = "Jane Doe";
        shippingAddress.City = "Istanbul";
        shippingAddress.Country = "Turkey";
        shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
        shippingAddress.ZipCode = "34742";

        Address billingAddress = new Address();
        billingAddress.ContactName = "Jane Doe";
        billingAddress.City = "Istanbul";
        billingAddress.Country = "Turkey";
        billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
        billingAddress.ZipCode = "34742";

        IyzipayRequest iyzipayRequest = new(Cash: decimal.Parse(txtCash.Text),
            CreditCardAmount: decimal.Parse(txtCC.Text),
            PaymentCard: paymentCard,
            Buyer: buyer,
            ShippingAddress: shippingAddress,
            BillingAddress: billingAddress
            );

        var result = this._frmAddition.PayTableAmount(iyzipayRequest);
        if (result == true) this.Close();
    }
}
