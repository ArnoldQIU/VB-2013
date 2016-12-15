Namespace 練習_農夫過河 { 
      Partial Public Class Form1 : Form 
      { 
          Public Form1()
          { 
               InitializeComponent(); 
           } 
           String[] name = New String[] { "菜", "羊", "狼", "農夫" };    
          Private void button1_Click(Object sender, EventArgs e) 
          { 
              MessageBox.Show("1.農夫一次只能帶一樣或空手過河。\n2.農夫不在時山羊會吃青菜，野狼會吃山羊。\n3.3件都帶過河就過關", "遊戲說明"); 
              button3.Enabled = false
          } 
   
          Private void Form1_Load(Object sender, EventArgs e) 
          { 
   
            listBox1.Items.AddRange(name); 
          } 
   
          Private void button2_Click(Object sender, EventArgs e) 
24          { 
25              for (int i = 0; i < name.Length; i++) 
26              { 
27   
28                  if (listBox1.SelectedItem == name[i])//for迴圈跟這個if是判斷我點選的是哪個 
29                  { 
30                      if (listBox1.SelectedItem == name[0] && listBox1.Items.Contains(name[1]) && listBox1.Items.Contains(name[2])) 
31                      { 
32                          MessageBox.Show("羊被狼吃掉"); 
33                      } 
34                      else if (listBox1.SelectedItem == name[3] && listBox1.Items.Contains(name[1]) && listBox1.Items.Contains(name[2])) 
35                      { 
36                          MessageBox.Show("羊被狼吃掉"); 
37                      } 
38                      else if (listBox1.SelectedItem==name[2] && listBox1.Items.Contains(name[0]) && listBox1.Items.Contains(name[1])) 
39                      { 
40                          MessageBox.Show("菜被羊吃掉"); 
41                      } 
42                      else if (listBox1.SelectedItem == name[3] && listBox1.Items.Contains(name[0]) && listBox1.Items.Contains(name[1]) && listBox2.Items.Contains(name[2])) 
43                      { 
44                          MessageBox.Show("菜被羊吃掉"); 
45                      } 
46                      else if (listBox1.SelectedItem == name[3])//農夫可以單獨過河 
47                      { 
48                          if (listBox1.Items.Contains(name[0]) && listBox1.Items.Contains(name[1]) && listBox1.Items.Contains(name[2])) 
49                          { 
50                              MessageBox.Show("通通吃光光");//農夫自己過河，菜被羊吃，羊被狼吃 
51                          } 
52                          else 
53                          { 
54                              listBox1.Items.Remove(name[3]); 
55                              listBox2.Items.Add(name[3]); 
56                              button2.Enabled = false;//農夫過河後，東西不能自己過河 
57                              listBox1.Enabled = false; 
58                              listBox2.Enabled = true; 
59                              button3.Enabled = true; 
60                          } 
61                      } 
62                      else 
63                      { 
64                          listBox2.Items.Add(name[i]);//菜、羊、狼過河，農夫一定會過河 
65                          listBox1.Items.Remove(name[i]); 
66                          listBox2.Items.Add(name[3]); 
67                          listBox1.Items.Remove(name[3]); 
68                          button2.Enabled = false; 
69                          button3.Enabled = true; 
70                          listBox1.Enabled = false; 
71                          listBox2.Enabled = true; 
72                          if (listBox1.Items.Count == 0) 
73                          { 
74                              MessageBox.Show("任務完成"); 
75                              Application.Exit(); 
76                          } 
77                      } 
78                  } 
79              } 
80          } 
81   
82   
83          private void button3_Click(object sender, EventArgs e) 
84          { 
85              for (int i = 0; i < name.Length; i++) 
86              { 
87                  if (listBox2.SelectedItem == name[i]) 
88                  { 
89   
90                      if (listBox2.SelectedItem == name[3])//農夫可以單獨過河 
91                      { 
92                          if (listBox2.Items.Contains(name[1]) && listBox2.Items.Contains(name[2])) 
93                          { 
94                              MessageBox.Show("羊被狼吃掉");//羊跟狼待在一起 
95                          } 
96                          else if (listBox2.Items.Contains(name[0]) && listBox2.Items.Contains(name[1])) 
97                          { 
98                              MessageBox.Show("菜被羊吃掉");//菜跟羊待在一起 
99                          } 
100                         else 
101                         { 
102                             listBox1.Items.Add(name[3]); 
103                             listBox2.Items.Remove(name[3]); 
104                             button3.Enabled = false;//農夫過河后東西不能自己過河 
105                             button2.Enabled = true; 
106                             listBox1.Enabled = true; 
107                             listBox2.Enabled = false; 
108                         } 
109                     } 
110                     else 
111                     { 
112  
113                         listBox1.Items.Add(name[i]);//菜、羊、狼過河，農夫一定會過河 
114                         listBox2.Items.Remove(name[i]); 
115                         listBox1.Items.Add(name[3]); 
116                         listBox2.Items.Remove(name[3]); 
117                         button3.Enabled = false; 
118                         button2.Enabled = true; 
119                         listBox1.Enabled = true; 
120                         listBox2.Enabled = false; 
121                     } 
122                 } 
123  
124             } 
125         } 
    } 
} 