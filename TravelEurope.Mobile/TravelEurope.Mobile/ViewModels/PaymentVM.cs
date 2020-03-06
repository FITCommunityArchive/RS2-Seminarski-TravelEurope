using System;
using System.Collections.Generic;
using System.Text;
using Acr.UserDialogs;
using TravelEurope.Mobile.Models;
using TravelEurope.Mobile.ViewsCustom;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Stripe;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelEurope.Mobile.ViewModels
{
    public class PaymentVM : BindableBase
    {
        #region Variable
        private CreditCardModel _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;
        private bool _isCarcValid;
        private bool _isTransectionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;

        #endregion Variable

        #region Public Property
        private string StripeTestApiKey = "pk_test_Lv9kMJZk4ns08GJOPriyuXVO00a24FlJLh";
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }

        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }

        public bool IsTransectionSuccess
        {
            get { return _isTransectionSuccess; }
            set { SetProperty(ref _isTransectionSuccess, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }

        public CreditCardModel CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }

        #endregion Public Property

        #region Constructor

        public PaymentVM()
        {
            CreditCardModel = new CreditCardModel();
            Title = "Card Details";
        }

        #endregion Constructor

        #region Command

        public DelegateCommand SubmitCommand => new DelegateCommand(async () =>
        {
            CreditCardModel.ExpMonth = Convert.ToInt64(ExpMonth);
            CreditCardModel.ExpYear = Convert.ToInt64(ExpYear);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                UserDialogs.Instance.ShowLoading("Payment processing..");
                await Task.Run(async () =>
                {

                    var Token = CreateToken();
                    Console.Write("Payment Gateway" + "Token :" + Token);
                    if (Token != null)
                    {
                        IsTransectionSuccess = MakePayment(Token);
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Bad card credentials", null, "OK");
                    }
                });
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");
                Console.Write("Payment Gatway" + ex.Message);
            }
            finally
            {
                if (IsTransectionSuccess)
                {
                    Console.Write("Payment Gateway" + "Payment Successful ");

                    UserDialogs.Instance.HideLoading();
                }
                else
                {

                    UserDialogs.Instance.HideLoading();
                    UserDialogs.Instance.Alert("Oops, something went wrong", "Payment failed", "OK");
                    Console.Write("Payment Gateway" + "Payment Failure ");
                }
            }

        });

        #endregion Command

        #region Method

        private string CreateToken()
        {
            try
            {
                StripeConfiguration.ApiKey = StripeTestApiKey;
                var service = new ChargeService();
                var Tokenoptions = new TokenCreateOptions
                {
                    Card = new CreditCardOptions
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name = "Faruk Redzic",
                        AddressLine1 = "19",
                        AddressLine2 = "Marka Marulića",
                        AddressCity = "Dolac Malta",
                        AddressZip = "77000",
                        AddressState = "Malta Dolac",
                        AddressCountry = "Bosna i Hercegovina",
                        Currency = "eur",
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool MakePayment(string token)
        {
            try
            {
                StripeConfiguration.ApiKey = "sk_test_u5PVeLrvvFRQGj89siYcIEpw00fedaueHy";
                var options = new ChargeCreateOptions
                {
                    Amount = (long)float.Parse("20000"),
                    Currency = "inr",
                    Description = "Charge for Jon.rosen@example.com",
                    Source = stripeToken.Id,
                    StatementDescriptor = "Custom descriptor",
                    Capture = true,
                    ReceiptEmail = "sonu.sharma@gmail.com",
                };
                //Make Payment
                var service = new ChargeService();
                Charge charge = service.Create(options);
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("Payment Gatway (CreateCharge)" + ex.Message);
                throw ex;
            }
        }

        private bool ValidateCard()
        {
            if (CreditCardModel.Number.Length == 16 && ExpMonth.Length == 2 && ExpYear.Length == 2 && CreditCardModel.Cvc.Length == 3)
            {
            }
            return true;
        }
        #endregion Method
    }
}