using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class phanso
    {
        private float tu, mau;
        public float TuSo
        {
            get { return tu; }
            set { tu = value; }
        }
        public float MauSo
        {
            get { return mau; }
            set
            {
                if (value != 0)
                    mau = value;
            }
        }
        public void nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("+ Nhập tử số: ");
            tu = float.Parse(Console.ReadLine());
            Console.Write("+ Nhập mẫu số: ");
            do
            {
                mau = float.Parse(Console.ReadLine());
                if(mau == 0)
                {
                    Console.Write("+ Mẫu số phải khác 0!!! Hãy nhập lại mẫu số: ");
                }

            } while (mau == 0);

        }
        public static phanso operator +(phanso phanSo1, phanso phanSo2) // toán tử cộng 2 phân  số
        {
            phanso phansoKQ = new phanso();
            phansoKQ.TuSo = phanSo1.TuSo * phanSo2.MauSo + phanSo2.TuSo * phanSo1.MauSo;
            phansoKQ.MauSo = phanSo1.MauSo * phanSo2.MauSo;
            return phansoKQ;
        }
        public static phanso operator -(phanso phanSo1, phanso phanSo2) // toán tử chia 2 phân số
        {
            phanso phansoKQ = new phanso();
            phansoKQ.TuSo = phanSo1.TuSo * phanSo2.MauSo - phanSo2.TuSo * phanSo1.MauSo;
            phansoKQ.MauSo = phanSo1.MauSo * phanSo2.MauSo;
            return phansoKQ;
        }
        public static phanso operator *(phanso phanSo1, phanso phanSo2) // toán tử * 2 phân số
        {
            phanso phansoKQ = new phanso();
            phansoKQ.TuSo = phanSo1.TuSo * phanSo2.TuSo;
            phansoKQ.MauSo = phanSo1.MauSo * phanSo2.MauSo;
            return phansoKQ;
        }
        public static phanso operator /(phanso phanSo1, phanso phanSo2)// toán tử / 2 phân số
        {
            phanso phansoKQ = new phanso();
            phansoKQ.TuSo = phanSo1.TuSo * phanSo2.MauSo;
            phansoKQ.MauSo = phanSo1.MauSo * phanSo2.TuSo;
            return phansoKQ;
        }

        public bool SoSanh(phanso a) // so sanh 2 phan so. neu >  la true, nguoc lai < la false.
        {
            float x;
            float y;
            if (MauSo != a.MauSo)
            {
                x = TuSo * a.MauSo;
                y = MauSo * a.TuSo;
            }
            else
            {
                x = TuSo;
                y = a.TuSo;
            }
            if (x > y)
                return true;
            return false;
        }
        public float UCLN(float a, float b) // tìm ước chung của tử số và mẫu số
        {
            a = Math.Abs(tu);
            b = Math.Abs(mau);
            while (a != b && b != 0 && a != 0)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }
        public phanso RutGonPhanSo() // rút gọn tử và mẫu
        {
            phanso rutgon = new phanso();
            float uoc = UCLN(tu, mau);
            if (uoc != 0)
            {
                rutgon.tu = tu / uoc;
                rutgon.mau = mau / uoc;
            }
            else
            {
                rutgon.tu = tu;
                rutgon.mau = mau;
            }
            return rutgon;
        }
        public void xuat()
        {
            Console.Write(" {0}/{1} ", tu, mau);
        }
    }
    class chuoiphanso
    {
        phanso[] ps;
        int n;
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng của phân :");
            n = Convert.ToInt32(Console.ReadLine());
            ps = new phanso[n];
            for (int i = 0; i < n; i++)
            {
                ps[i] = new phanso();
                Console.WriteLine("Phân số thứ {0}", i + 1);
                ps[i].nhap();
                ps[i] = ps[i].RutGonPhanSo();
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < n; i++)
            {
                ps[i].xuat();
                Console.Write(" , ");
            }
        }
        
        public phanso tinhtong()
        {
            phanso tong = ps[0];
            for (int i = 1; i < n; i++)
            {
                tong = tong + ps[i];
            }
            return tong;
        }
        public phanso tinhhieu()
        {
            phanso hieu = ps[0];
            for (int i = 1; i < n; i++)
            {
                hieu = hieu - ps[i];
            }
            return hieu;
        }
        public phanso tinhtich()
        {
            phanso tich = ps[0];
            for (int i = 1; i < n; i++)
            {
                tich = tich * ps[i];
            }
            return tich;
        }
        public phanso tinhthuong()
        {
            phanso thuong = ps[0];
            for (int i = 1; i < n; i++)
            {
                thuong = ps[i]/thuong;
            }
            return thuong;
        }
        public void sapxeptangdan()// Sắp xếp tăng dần...
        {
            for (int i = 0; i < n - 1; i++)
            {

                for (int j = 1; j < n; j++)
                {
                    if (ps[j].SoSanh( ps[i])==false)
                    {
                        //cach trao doi gia tri
                        phanso temp;
                        temp = ps[i];
                        ps[i] = ps[j];
                        ps[j] = temp;
                    }
                }
            }
        }
        public void sapxepgiamdan()// Sắp xếp giảm dần...
        {
            for (int i = 0; i < n - 1; i++)
            {

                for (int j = 1; j < n; j++)
                {
                    if (ps[j].SoSanh(ps[i]) == true)
                    {
                        //cach trao doi gia tri
                        phanso temp;
                        temp = ps[i];
                        ps[i] = ps[j];
                        ps[j] = temp;
                    }
                }
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            chuoiphanso c = new chuoiphanso();
            c.Nhap();
            Console.Write("\nSắp xếp tăng dần: ");
            c.sapxeptangdan();
            c.Xuat();
            Console.Write("\nSắp xếp giảm dần: ");
            c.sapxepgiamdan();
            c.Xuat();
            phanso tong = c.tinhtong();
            Console.Write("\nTổng  là: ");
            tong.xuat();
            phanso hieu = c.tinhhieu();
            Console.Write("\nHiệu là: ");
            hieu.xuat();
            phanso tich = c.tinhtich();
            Console.Write("\nTích  là: ");
            tich.xuat();
            phanso thuong = c.tinhthuong();
            Console.Write("\nThương  là: ");
            thuong.xuat();
            Console.ReadLine();
        }
    }
}
