using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.Errors
{
    public static class ErrorsString
    {
        //Database Error
        //Connection to DB
        public static string Error001 = "هنالك مشكلة في الاتصال 001, الرجاء التواصل مع مدير النظام";
        //Error While Executing a query to DB
        public static string Error002 = "خطأ رقم 002, الرجاء الإتصال بمدير النظام";

        //Recharge Error
        //Connectiong to Recharche table
        public static string Error010 = "خطأ رقم 010و لا يمكن استرجاع بيانات السنة المالية او القيمة المتاحة";
        //Recharge and Issuense is not active
        public static string Error011 = "خطأ رقم 011, الشحن و الإصدار غير متاح";
        //No Customer in DB
        public static string Error012 = "لا يوجد زبون بهذا الرقم في قاعدة البيانات.يمكنك الإستمرار و لكن لتخزين بيانات هذا الزبون تأكد من صحة بياناته";

    }

}
