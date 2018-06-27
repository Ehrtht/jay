using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace jay
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string[] song = { "驚嘆號", "龍拳","最後的戰役", "天台", "比較大的大提琴", "快門慢舞", "打架舞","哪裡都是你", "一路向北","不能說的秘密","雙截棍", "明明就", "Mine Mine","龍捲風","公公偏頭痛", "青花瓷", "鬥牛", "水手怕水", "大笨鐘", "彩虹", "軌跡", "手語", "開不了口", "烏克麗麗", "陽光宅男","床邊故事","說走就走","一點點","前世情人","英雄","不該","土耳其冰淇淋","告白氣球","Now You See Me","愛情廢柴","陽明山","竊愛","算什麼男人","天涯過客","怎麼了","一口氣全唸對","我要夏天","手寫的從前","鞋子特大號","聽爸爸的話","美人魚","聽見下雨的聲音","四季列車","傻笑","愛你沒差","紅塵客棧","夢想啟動","大笨鐘","哪裡都是你","迷魂曲","公主病","你好嗎","療傷燒肉粽","琴傷","世界未末日","皮影戲","超跑女神","天地一鬥","龍戰騎士","跨時代",
"蛇舞","愛在西元前","我不配","嘻哈空姐","威廉古堡","魔術先生","黑色幽默","想你就寫信","你是我的OK繃","稻香","陽光宅男","說好的幸福呢","淘汰","免費教學錄影帶","時光機","爸 我回來了","雨下一整晚","愛的飛行日記","以父之名","開不了口","東風破","說了再見","煙花易冷","好久不見","雨下一整晚","我落淚。情緒零碎","愛的飛行日記","自導自演","超人不會飛","龍戰騎士","給我一首歌的時間","花海","蘭亭序","流浪詩人","時光機","喬克叔叔","牛仔很忙","彩虹","蒲公英的約定","無雙","我不配","扯","甜甜的","最長的電影","可愛女人","最後的戰役","半獸人","夜的第七章","夜曲","園遊會","困獸之鬥","米蘭的小鐵匠","暗號","擱淺","懦夫","晴天","三年二班","你聽得到","同一種調調","他的睫毛","愛情懸崖","梯田","雙刀"};
        Random rnd = new Random();
       
        private void one_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < song.Length; i++)

            {
            // 先將目前位置中的元素複製一份（為了交換用）
            string temp = song[i];
    
            // 將第隨機個元素放到目前位置（交換)
            int r = rnd.Next(0, song.Length);
            song[i] = song[r];
    
            // 將備份的元素放到剛才那隨機的位置上（完成交換）
            song[r] = temp;
            textbox1.Text = song[i].ToString();
            }
        }

        private void ten_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < song.Length; i++)
            {
                // 先將目前位置中的元素複製一份（為了交換用）
                string temp = song[i];

                // 將第隨機個元素放到目前位置（交換)
                int r = rnd.Next(0, song.Length);
                song[i] = song[r];
                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                song[r] = temp;
                textbox1.Text = song[i].ToString();
            }

            for (int i = 0; i < song.Length; i++)
            {
                // 先將目前位置中的元素複製一份（為了交換用）
                string temp = song[i];
                int x = rnd.Next(0, song.Length);
                song[i] = song[x];
                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                song[x] = temp;
                textbox2.Text = song[i].ToString();
            }

            for (int i = 0; i < song.Length; i++)
            {
                // 先將目前位置中的元素複製一份（為了交換用）
                string temp = song[i];
                int y = rnd.Next(0, song.Length);
                song[i] = song[y];
                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                song[y] = temp;
                textbox3.Text = song[i].ToString();
            }

            for (int i = 0; i < song.Length; i++)
            {
                // 先將目前位置中的元素複製一份（為了交換用）
                string temp = song[i];
                int z = rnd.Next(0, song.Length);
                song[i] = song[z];
                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                song[z] = temp;
                textbox4.Text = song[i].ToString();
            }

            for (int i = 0; i < song.Length; i++)
            {
                // 先將目前位置中的元素複製一份（為了交換用）
                string temp = song[i];
                int q = rnd.Next(0, song.Length);
                song[i] = song[q];
                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                song[q] = temp;
                textbox5.Text = song[i].ToString();
            }

            for (int i = 0; i < song.Length; i++)
            {
                // 先將目前位置中的元素複製一份（為了交換用）
                string temp = song[i];

                // 將第隨機個元素放到目前位置（交換)
                int r = rnd.Next(0, song.Length);
                song[i] = song[r];
                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                song[r] = temp;
                textbox6.Text = song[i].ToString();
            }

            for (int i = 0; i < song.Length; i++)
            {
                // 先將目前位置中的元素複製一份（為了交換用）
                string temp = song[i];
                int x = rnd.Next(0, song.Length);
                song[i] = song[x];
                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                song[x] = temp;
                textbox7.Text = song[i].ToString();
            }

            for (int i = 0; i < song.Length; i++)
            {
                // 先將目前位置中的元素複製一份（為了交換用）
                string temp = song[i];
                int y = rnd.Next(0, song.Length);
                song[i] = song[y];
                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                song[y] = temp;
                textbox8.Text = song[i].ToString();
            }

            for (int i = 0; i < song.Length; i++)
            {
                // 先將目前位置中的元素複製一份（為了交換用）
                string temp = song[i];
                int z = rnd.Next(0, song.Length);
                song[i] = song[z];
                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                song[z] = temp;
                textbox9.Text = song[i].ToString();
            }

            for (int i = 0; i < song.Length; i++)
            {
                // 先將目前位置中的元素複製一份（為了交換用）
                string temp = song[i];
                int q = rnd.Next(0, song.Length);
                song[i] = song[q];
                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                song[q] = temp;
                textbox10.Text = song[i].ToString();
            }
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < song.Length; i++)
            {
                // 先將目前位置中的元素複製一份（為了交換用）
                string temp = song[i];

                // 將第隨機個元素放到目前位置（交換)
                int r = rnd.Next(0, song.Length);
                song[i] = song[r];
                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                song[r] = temp;
                textbox1.Text = song[i].ToString();
            }
           
            for (int i = 0; i < song.Length; i++)
            {
                // 先將目前位置中的元素複製一份（為了交換用）
                string temp = song[i];
                int x = rnd.Next(0, song.Length);
                song[i] = song[x];
                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                song[x] = temp;
                textbox2.Text = song[i].ToString();
            }
           
            for (int i = 0; i < song.Length; i++)
            {
                // 先將目前位置中的元素複製一份（為了交換用）
                string temp = song[i];
                int y = rnd.Next(0, song.Length);
                song[i] = song[y];
                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                song[y] = temp;
                textbox3.Text = song[i].ToString();
            }
           
            for (int i = 0; i < song.Length; i++)
            {
                // 先將目前位置中的元素複製一份（為了交換用）
                string temp = song[i];
                int z = rnd.Next(0, song.Length);
                song[i] = song[z];
                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                song[z] = temp;
                textbox4.Text = song[i].ToString();
            }

            for (int i = 0; i < song.Length; i++)
            {
                // 先將目前位置中的元素複製一份（為了交換用）
                string temp = song[i];
                int q = rnd.Next(0, song.Length);
                song[i] = song[q];
                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                song[q] = temp;
                textbox5.Text = song[i].ToString();
            }
        }
    }
}
