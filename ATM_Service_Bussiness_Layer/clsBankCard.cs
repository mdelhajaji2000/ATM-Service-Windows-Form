using ATM_Service_Data_Access_Layer;
using BusinessTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Service_Bussiness_Layer
{
    public class clsBankCard
    {
        public int CardId { get; private set; }
        public int CardNumber { get; private set; }
        public bool ActivationStatus { get; set; }
        public DateTime CreationDate { get; set; }
        public int AccountNumber { get; private set; }

        public int PinCode { get; set; }

        public clsClientAccount AccountInfo;

        private clsBankCard(int CardID, int CardNumber, int AccountNumber, bool ActiveStatus, DateTime CreationDate, int PinCode)
        {
            this.CardId = CardID;
            this.CardNumber = CardNumber;
            this.AccountNumber = AccountNumber;
            this.ActivationStatus = ActiveStatus;
            this.CreationDate = CreationDate;
            this.PinCode = PinCode;
            this.AccountInfo = clsClientAccount.Find(this.AccountNumber);
        }

        public static clsBankCard Find(int CardNumber)
        {
            int PinCode = -1;
            int CardID = -1;
            bool ActiveStatus = false;
            DateTime CreationDate = DateTime.Now;
            int AccNumber = -1;

            if (clsBankCardData.GetCardByCardNumber(CardNumber, ref CardID, ref AccNumber, ref PinCode, ref ActiveStatus, ref CreationDate))
                return new clsBankCard(CardID, CardNumber, AccNumber, ActiveStatus, CreationDate, PinCode);
            else
                return null;
        }

        public bool Save()
        {

            this.CardId = clsBankCardData.CreateBankCardinDataBase(this.CardNumber, this.CreationDate, this.ActivationStatus, this.PinCode, this.AccountNumber);

            return CardId != -1;
        }

        public bool ActivateCard()
        {
            return clsBankCardData.ChangeActivationStatus(this.CardId, true);
        }

        public bool DesactivateCard()
        {
            return clsBankCardData.ChangeActivationStatus(this.CardId, false);
        }

        public bool ChangePinCode(int NewPinCode)
        {
            return clsBankCardData.ChangeCodePin(this.CardId, NewPinCode);
        }
    }
}
