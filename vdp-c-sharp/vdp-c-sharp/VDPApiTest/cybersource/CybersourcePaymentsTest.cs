﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;


namespace Vdp
{
    [TestClass]
    public class CybersourcePaymentsTest
    {
        private string paymentAuthorizationRequest;
        private AbstractVisaAPIClient abstractVisaAPIClient;

        public CybersourcePaymentsTest()
        {
            abstractVisaAPIClient = new AbstractVisaAPIClient();
            paymentAuthorizationRequest =
           "{\"amount\": \"0\","
               + "\"currency\": \"USD\","
               + "\"payment\": {"
                   + "\"cardNumber\": \"4111111111111111\","
                   + "\"cardExpirationMonth\": \"10\","
                   + "\"cardExpirationYear\": \"2016\""
                   + "}"
               + "}";
        }

        [TestMethod]
        public void TestPaymentAuthorizations()
        {
            string baseUri = "cybersource/";
            string resourcePath = "payments/v1/authorizations";
            string queryString = "apikey=" + ConfigurationManager.AppSettings["apiKey"];
            string status = abstractVisaAPIClient.DoXPayTokenCall(baseUri, resourcePath, queryString, "POST", "Cybersouce Payments Authorization Test", paymentAuthorizationRequest);
            Assert.AreEqual(status, "Created");
        }
    }
}