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
    /// Сотрудник.
    /// </summary>
    // *** Start programmer edit section *** (Сотрудник CustomAttributes)

    // *** End programmer edit section *** (Сотрудник CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СотрудникE", new string[] {
            "ТабельныйНомер as \'Табельный номер\'",
            "Фамилия as \'Фамилия\'",
            "Имя as \'Имя\'",
            "Отчество as \'Отчество\'",
            "Телефон as \'Телефон\'",
            "EMail as \'E mail\'",
            "Склад as \'Склад\'",
            "Склад.Адрес as \'Адрес\'"})]
    [View("СотрудникL", new string[] {
            "ТабельныйНомер as \'Табельный номер\'",
            "Фамилия as \'Фамилия\'",
            "Имя as \'Имя\'",
            "Отчество as \'Отчество\'",
            "Телефон as \'Телефон\'",
            "EMail as \'E mail\'",
            "Склад.Адрес as \'Адрес\'"})]
    public class Сотрудник : ICSSoft.STORMNET.DataObject
    {
        
        private int fТабельныйНомер;
        
        private string fФамилия;
        
        private string fИмя;
        
        private string fОтчество;
        
        private string fТелефон;
        
        private string fEMail;
        
        private IIS.АСУ_Склад.Склад fСклад;
        
        // *** Start programmer edit section *** (Сотрудник CustomMembers)

        // *** End programmer edit section *** (Сотрудник CustomMembers)

        
        /// <summary>
        /// ТабельныйНомер.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.ТабельныйНомер CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.ТабельныйНомер CustomAttributes)
        public virtual int ТабельныйНомер
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.ТабельныйНомер Get start)

                // *** End programmer edit section *** (Сотрудник.ТабельныйНомер Get start)
                int result = this.fТабельныйНомер;
                // *** Start programmer edit section *** (Сотрудник.ТабельныйНомер Get end)

                // *** End programmer edit section *** (Сотрудник.ТабельныйНомер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.ТабельныйНомер Set start)

                // *** End programmer edit section *** (Сотрудник.ТабельныйНомер Set start)
                this.fТабельныйНомер = value;
                // *** Start programmer edit section *** (Сотрудник.ТабельныйНомер Set end)

                // *** End programmer edit section *** (Сотрудник.ТабельныйНомер Set end)
            }
        }
        
        /// <summary>
        /// Фамилия.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Фамилия CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Фамилия CustomAttributes)
        [StrLen(255)]
        public virtual string Фамилия
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Фамилия Get start)

                // *** End programmer edit section *** (Сотрудник.Фамилия Get start)
                string result = this.fФамилия;
                // *** Start programmer edit section *** (Сотрудник.Фамилия Get end)

                // *** End programmer edit section *** (Сотрудник.Фамилия Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Фамилия Set start)

                // *** End programmer edit section *** (Сотрудник.Фамилия Set start)
                this.fФамилия = value;
                // *** Start programmer edit section *** (Сотрудник.Фамилия Set end)

                // *** End programmer edit section *** (Сотрудник.Фамилия Set end)
            }
        }
        
        /// <summary>
        /// Имя.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Имя CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Имя CustomAttributes)
        [StrLen(255)]
        public virtual string Имя
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Имя Get start)

                // *** End programmer edit section *** (Сотрудник.Имя Get start)
                string result = this.fИмя;
                // *** Start programmer edit section *** (Сотрудник.Имя Get end)

                // *** End programmer edit section *** (Сотрудник.Имя Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Имя Set start)

                // *** End programmer edit section *** (Сотрудник.Имя Set start)
                this.fИмя = value;
                // *** Start programmer edit section *** (Сотрудник.Имя Set end)

                // *** End programmer edit section *** (Сотрудник.Имя Set end)
            }
        }
        
        /// <summary>
        /// Отчество.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Отчество CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Отчество CustomAttributes)
        [StrLen(255)]
        public virtual string Отчество
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Отчество Get start)

                // *** End programmer edit section *** (Сотрудник.Отчество Get start)
                string result = this.fОтчество;
                // *** Start programmer edit section *** (Сотрудник.Отчество Get end)

                // *** End programmer edit section *** (Сотрудник.Отчество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Отчество Set start)

                // *** End programmer edit section *** (Сотрудник.Отчество Set start)
                this.fОтчество = value;
                // *** Start programmer edit section *** (Сотрудник.Отчество Set end)

                // *** End programmer edit section *** (Сотрудник.Отчество Set end)
            }
        }
        
        /// <summary>
        /// Телефон.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Телефон CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Телефон CustomAttributes)
        [StrLen(255)]
        public virtual string Телефон
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Телефон Get start)

                // *** End programmer edit section *** (Сотрудник.Телефон Get start)
                string result = this.fТелефон;
                // *** Start programmer edit section *** (Сотрудник.Телефон Get end)

                // *** End programmer edit section *** (Сотрудник.Телефон Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Телефон Set start)

                // *** End programmer edit section *** (Сотрудник.Телефон Set start)
                this.fТелефон = value;
                // *** Start programmer edit section *** (Сотрудник.Телефон Set end)

                // *** End programmer edit section *** (Сотрудник.Телефон Set end)
            }
        }
        
        /// <summary>
        /// EMail.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.EMail CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.EMail CustomAttributes)
        [StrLen(255)]
        public virtual string EMail
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.EMail Get start)

                // *** End programmer edit section *** (Сотрудник.EMail Get start)
                string result = this.fEMail;
                // *** Start programmer edit section *** (Сотрудник.EMail Get end)

                // *** End programmer edit section *** (Сотрудник.EMail Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.EMail Set start)

                // *** End programmer edit section *** (Сотрудник.EMail Set start)
                this.fEMail = value;
                // *** Start programmer edit section *** (Сотрудник.EMail Set end)

                // *** End programmer edit section *** (Сотрудник.EMail Set end)
            }
        }
        
        /// <summary>
        /// Сотрудник.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Склад CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Склад CustomAttributes)
        [PropertyStorage(new string[] {
                "Склад"})]
        [NotNull()]
        public virtual IIS.АСУ_Склад.Склад Склад
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Склад Get start)

                // *** End programmer edit section *** (Сотрудник.Склад Get start)
                IIS.АСУ_Склад.Склад result = this.fСклад;
                // *** Start programmer edit section *** (Сотрудник.Склад Get end)

                // *** End programmer edit section *** (Сотрудник.Склад Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Склад Set start)

                // *** End programmer edit section *** (Сотрудник.Склад Set start)
                this.fСклад = value;
                // *** Start programmer edit section *** (Сотрудник.Склад Set end)

                // *** End programmer edit section *** (Сотрудник.Склад Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СотрудникE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникE", typeof(IIS.АСУ_Склад.Сотрудник));
                }
            }
            
            /// <summary>
            /// "СотрудникL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникL", typeof(IIS.АСУ_Склад.Сотрудник));
                }
            }
        }
    }
}
