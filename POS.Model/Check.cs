using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class Check
    {
        public long Id { get; set; }

        /// <summary>
        /// تاریخ سررسید
        /// </summary>
        public DateTime? MaturityDate { get; set; }

        /// <summary>
        /// تاریخ صدور
        /// </summary>
        public DateTime? IssuedDate { get; set; }

        /// <summary>
        /// تاریخ پاس شدن
        /// </summary>
        public DateTime? PassedDate { get; set; }

        /// <summary>
        /// نام بانک
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// شماره چک
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// توضیحات اضافه
        /// </summary>
        public string Description { get; set; }


        public virtual Payment Payment { get; set; }

        public virtual Receipt Receipt { get; set; }
    }
}
