using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap_5
{
    public class News: INews
    {
        public String publicDate;
        public String content;
        List<float> avgRate;

        public News() { }
        public News(String id, String title, String author, String publicDate, String content, List<float> avgRate) {
            this.id = id;
            this.title = title;
            this.author = author;
            this.publicDate = publicDate;
            this.content = content;
            this.avgRate = avgRate;
        }

        public String id { get; set; }
        public String title { get; set; }
        public String author { get; set; }

        public void Display(ConsoleKeyInfo k)
        {
            if (k.KeyChar == '2')
            {
                Console.WriteLine($"\nMa tin tuc: {id}, Ten tin tuc: {title}, Tac gia: {author}, Ngay dang: {publicDate}, Noi dung: {content}");
            }
            if(k.KeyChar == '3')
            {
                Console.WriteLine($"\nMa tin tuc: {id}, Ten tin tuc: {title}, Tac gia: {author}, Ngay dang: {publicDate}, Diem danh gia trung binh: {Cal_Avg(avgRate)}");
               
            }
        }

        public float Cal_Avg(List<float> avgRate)
        {
           return avgRate.Average();
        }



    }
}
