using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Database.Objects
{
  public  class PTSAppRecord
    {
        public int RecordID;
        public string CustomerID;
        public string BankCode;
        public char ApplicationType;
        public char ApplicationSubType;
        public string ProgramCode;
        public string DeviceNumber;
        public string DeviceType1;
        public string DevicePlanCode1;
        public string BranchCode;
        public string Inputter;
        public DateTime InputTime;
        public string BranchAuthorizer;
        public DateTime BranchAuthTime;
        public string HQAuthorizer;
        public DateTime HQAuthTime;
        public bool Generated;

        //Usually empty fields
        public string FromNumber;
        public string CustomerType;
        public string ExistingDeviceNumber;
        public string ExistingClientCode;
        public string ExistingAddonClientCode;
        public string RelationwithPrimaryClient;
        public string WalletPlan1Promo;
        public string WalletPlan2Promo;
        public string WalletPlan3Promo;

        public string DeviceType2;
        public string DeviceType3;
        public string DeviceType4;
        public string DeviceType5;
        public string DeviceType6;


        public string DevicePlanCode2;
        public string DevicePlanCode3;
        public string DevicePlanCode4;
        public string DevicePlanCode5;
        public string DevicePlanCode6;

        public string DevicePlanPromoCode1;
        public string DevicePlanPromoCode2;
        public string DevicePlanPromoCode3;
        public string DevicePlanPromoCode4;
        public string DevicePlanPromoCode5;
        public string DevicePlanPromoCode6;



        public string DevicePhotoIndicator1;
        public string DevicePhotoIndicator2;
        public string DevicePhotoIndicator3;
        public string DevicePhotoIndicator4;
        public string DevicePhotoIndicator5;
        public string DevicePhotoIndicator6;










    }
}
