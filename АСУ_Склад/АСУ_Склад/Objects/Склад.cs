﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.АСУ_Склад
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Склад.
    /// </summary>
    // *** Start programmer edit section *** (Склад CustomAttributes)

    // *** End programmer edit section *** (Склад CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СкладE", new string[] {
            "Номер as \'Номер\'",
            "Адрес as \'Адрес\'"})]
    [AssociatedDetailViewAttribute("СкладE", "ТоварНаСкладе", "ТоварНаСкладеE", true, "", "Товар на складе", true, new string[] {
            ""})]
    [View("СкладL", new string[] {
            "Номер as \'Номер\'",
            "Адрес as \'Адрес\'"})]
    public class Склад : ICSSoft.STORMNET.DataObject
    {
        
        private int fНомер;
        
        private string fАдрес;
        
        private IIS.АСУ_Склад.DetailArrayOfТоварНаСкладе fТоварНаСкладе;
        
        // *** Start programmer edit section *** (Склад CustomMembers)

        // *** End programmer edit section *** (Склад CustomMembers)

        
        /// <summary>
        /// Номер.
        /// </summary>
        // *** Start programmer edit section *** (Склад.Номер CustomAttributes)

        // *** End programmer edit section *** (Склад.Номер CustomAttributes)
        public virtual int Номер
        {
            get
            {
                // *** Start programmer edit section *** (Склад.Номер Get start)

                // *** End programmer edit section *** (Склад.Номер Get start)
                int result = this.fНомер;
                // *** Start programmer edit section *** (Склад.Номер Get end)

                // *** End programmer edit section *** (Склад.Номер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Склад.Номер Set start)

                // *** End programmer edit section *** (Склад.Номер Set start)
                this.fНомер = value;
                // *** Start programmer edit section *** (Склад.Номер Set end)

                // *** End programmer edit section *** (Склад.Номер Set end)
            }
        }
        
        /// <summary>
        /// Адрес.
        /// </summary>
        // *** Start programmer edit section *** (Склад.Адрес CustomAttributes)

        // *** End programmer edit section *** (Склад.Адрес CustomAttributes)
        [StrLen(255)]
        public virtual string Адрес
        {
            get
            {
                // *** Start programmer edit section *** (Склад.Адрес Get start)

                // *** End programmer edit section *** (Склад.Адрес Get start)
                string result = this.fАдрес;
                // *** Start programmer edit section *** (Склад.Адрес Get end)

                // *** End programmer edit section *** (Склад.Адрес Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Склад.Адрес Set start)

                // *** End programmer edit section *** (Склад.Адрес Set start)
                this.fАдрес = value;
                // *** Start programmer edit section *** (Склад.Адрес Set end)

                // *** End programmer edit section *** (Склад.Адрес Set end)
            }
        }
        
        /// <summary>
        /// Склад.
        /// </summary>
        // *** Start programmer edit section *** (Склад.ТоварНаСкладе CustomAttributes)

        // *** End programmer edit section *** (Склад.ТоварНаСкладе CustomAttributes)
        public virtual IIS.АСУ_Склад.DetailArrayOfТоварНаСкладе ТоварНаСкладе
        {
            get
            {
                // *** Start programmer edit section *** (Склад.ТоварНаСкладе Get start)

                // *** End programmer edit section *** (Склад.ТоварНаСкладе Get start)
                if ((this.fТоварНаСкладе == null))
                {
                    this.fТоварНаСкладе = new IIS.АСУ_Склад.DetailArrayOfТоварНаСкладе(this);
                }
                IIS.АСУ_Склад.DetailArrayOfТоварНаСкладе result = this.fТоварНаСкладе;
                // *** Start programmer edit section *** (Склад.ТоварНаСкладе Get end)

                // *** End programmer edit section *** (Склад.ТоварНаСкладе Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Склад.ТоварНаСкладе Set start)

                // *** End programmer edit section *** (Склад.ТоварНаСкладе Set start)
                this.fТоварНаСкладе = value;
                // *** Start programmer edit section *** (Склад.ТоварНаСкладе Set end)

                // *** End programmer edit section *** (Склад.ТоварНаСкладе Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СкладE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СкладE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СкладE", typeof(IIS.АСУ_Склад.Склад));
                }
            }
            
            /// <summary>
            /// "СкладL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СкладL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СкладL", typeof(IIS.АСУ_Склад.Склад));
                }
            }
        }
    }
}
