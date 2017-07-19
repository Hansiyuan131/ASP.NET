using System;
using System.Collections.Generic;
using System.Text;

namespace RentalSystem
{
    /// <summary>
    /// ������ ����������һЩ������Ϣ
    /// </summary>
    public abstract class Vehicle
    {
        public Vehicle() { }
        public Vehicle(string licenseNO, string name, string color, int yearsOfService, double dailyRent)
        {
            this.LicenseNO = licenseNO;
            this.Name = name;
            this.Color = color;
            this.YearsOfService = yearsOfService;
            this.DailyRent = dailyRent;
        }
        /// <summary>
        /// ���ƺ�
        /// </summary>
        private string licenseNO;
        public string LicenseNO
        {
            get { return licenseNO; }
            set { licenseNO = value; }
        }
        /// <summary>
        /// ����
        /// </summary>
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// ��ɫ
        /// </summary>
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        /// <summary>
        /// ʹ������
        /// </summary>
        private int yearsOfService;
        public int YearsOfService
        {
            get { return yearsOfService; }
            set { yearsOfService = value; }
        }
        /// <summary>
        /// �����
        /// </summary>
        private double dailyRent;
        public double DailyRent
        {
            get { return dailyRent; }
            set { dailyRent = value; }
        }
        //������
        private string rentUser;
        public string RentUser
        {
            get { return rentUser; }
            set { rentUser = value; }
        }
        //��������
        private int rentDate;
        public int RentDate
        {
            get { return rentDate; }
            set { rentDate = value; }
        }
        /// <summary>
        /// ����۸�ķ���
        /// </summary>
        /// <returns></returns>
        public abstract double CalcPrice();
    }
}
