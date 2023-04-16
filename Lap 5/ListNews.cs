using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap_5
{
    internal class ListNews
    {
        int n;
        List<News> list = new List<News>();
        News news = new News();

        public void Input()
        {
            Console.WriteLine("Co bao nhieu tin tuc trong ngay hom nay nao?: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                int p;
                List<float> avgRate = new List<float>();
                Console.WriteLine("Nhap tin tuc {0}", i + 1);
                Console.Write("Ma tin tuc: ");
                String id = Console.ReadLine();
                Console.Write("Tieu de tin tuc: ");
                String title = Console.ReadLine();
                Console.Write("Tac gia: ");
                String author = Console.ReadLine();
                Console.Write("Ngay dang: ");
                String publicDate = Console.ReadLine();
                Console.Write("Noi dung: ");
                String content = Console.ReadLine();
                Console.Write("Nhap so lan danh gia: ");
                p = int.Parse(Console.ReadLine());
                for (int j = 0; j < p; j++)
                {
                    Console.Write("\nSo diem lan danh gia thu {0}: ", j+1);
                    float rate = float.Parse(Console.ReadLine());
                    avgRate.Add(rate);
                }
                    News news = new News(id, title, author, publicDate, content, avgRate);
                    list.Add(news);            

            }
        }

        public void Output(ConsoleKeyInfo key)
        {
           foreach(News news in list)
            {
                if (key.KeyChar == '2')
                {
                    news.Display(key);
                }
                if (key.KeyChar == '3')
                {
                    news.Display(key);
                }
            }
        }

        public void insert()
        {
            int p;
            List<float> avgRate = new List<float>();
            Console.Write("\nMa tin tuc: ");
            String id = Console.ReadLine();
            Console.Write("Tieu de tin tuc: ");
            String title = Console.ReadLine();
            Console.Write("Tac gia: ");
            String author = Console.ReadLine();
            Console.Write("Ngay dang: ");
            String publicDate = Console.ReadLine();
            Console.Write("Noi dung: ");
            String content = Console.ReadLine();
            Console.Write("Nhap so lan danh gia: ");
            p = int.Parse(Console.ReadLine());
            for (int i = 0; i < p; i++)
            {
                Console.Write("\nSo diem lan danh gia thu {0}: ", i + 1);
                float rate = float.Parse(Console.ReadLine());
                avgRate.Add(rate);
            }
            News news2 = new News(id, title, author, publicDate, content, avgRate);
            list.Insert(n,news2);
            Console.WriteLine("Danh sach sau khi them: ");
            Console.WriteLine($"Ma tin tuc: {id}, Ten tin tuc: {title}, Tac gia: {author}, Ngay dang: {publicDate}, Noi dung: {content}");
        }


    }
}
