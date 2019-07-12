/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2019/7/11
 * 时间: 10:28
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace RandomName
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//定义变量
			string malePath=@"./male.ini";
			string femalePath=@"./female.ini";
			string custPath=@"./custom.ini";
			string maleContent;
			string femaleContent;
			string custContent;
			if(!File.Exists(malePath))//判断文件是否存在
			{
				maleContent="伟,强,华,成,礼,敏,源,浩,辉,俊,霞,良,仪,志,新,文,乐,天,和,光,雅,逸,高,君,昊,元,勋,敏,达,轩,鸿,卓,语,堂,翔,宇,灿,修,竹,宏,胜,凯,定,嘉,寿,永,康,炎,彬,雨,伯,茂,星,波,能,绍,辉,振,国,本,远,航,升,荣,谊,焱,德,馨,勇,军,福,阳,云,睿,明,树,雄,毅,耀,范,信,翼,瀚,衍,力,行,正,义,学,子,晔,昌,苍,昱,才,涵,煦,阳,旭,祺,祥,斌,澹,啸,炫,季,鑫,邈,润,奕,朗,延,卫,奇,峻,圣,业,适,心,朝,泰,靖,畅,歌,清,楷,飞,石,舟,又,雪,松,玉,书,烨,烁,咏,纬,致,驰,磊,晟,佑,洁,黎,昕,越,瑾,瑜,擎,渊,建,晋,煊,骞,鹤,风,懿,智,立,豪,杰,霖,鹏,聪,思,淼,默,锦,然,家,博,青,安,楠,山,森,秋";
				Write(malePath,maleContent);//写入内容
			}
			if(!File.Exists(femalePath))//判断文件是否存在
			{
				femaleContent="梦,灵,寒,碧,冰,玉,凝,妙,笑,丹,语,容,初,巧,芙,静,雪,岚,柔,翠,萱,晴,瑶,雨,亦,芹,幼,晓,觅,海,映,若,香,紫,绮,蕊,水,薇,新,梅,蕾,含,书,云,乐,秋,冬,露,寒,柳,婧,荷,小,儿,安,春,之,文,听,天,芷,凌,兰,元,又,白,寻,阳,访,山,沛,半,柏,凡,惜,丝,槐,盼,怀,琴,双,夏,采,如,诗,青,彤,夜,幻,宛,雅,枫,迎,忆,烟,阳,念,依,思,以,蓝,尔,萍,易,烨,闰,立,博,轩,涛,熠,炫,缘,远,熙,堂,泽,旭,余,玲,欣,婷,宜,家,怡,琳,慧,志,佩,乔,哲,仁,贤,淑,娟,昌,明,颖,美,均,宝,启,恩,霖,铭,倩,信,舒,伦,心,梓,虹,叶,田,真,林,慕,宁,宇,情,愉,允,欢,莹,晶,雯,霁,音,璇,风,逸,桃,韵,向,素,月,方,莉,希,菁,金,悦,霓,娜,悠,漪,庄,玫,醉,芝,南,竹,晨,蝶,菲,奕,钰,冷,洁,蔚,仪,丽,雁,莲,松,姝,贝,欣,绿,问,瑞,银,然,懿,潼,槿,妍,卉,楠,溪,娴,澜,涵,可,萧,艺,千";
				Write(femalePath,femaleContent);//写入内容
			}
			if(!File.Exists(custPath))//判断文件是否存在
			{
				custContent="伟,强,华,成,礼";
				Write(custPath,custContent);//写入内容
			}
			
		}
		public void Write(string path,string singleName)//文件操作写入
		{
			FileStream fs = new FileStream(path,FileMode.Create);
			StreamWriter sw = new StreamWriter(fs);
			sw.Write(singleName);
			sw.Flush();
			sw.Close();
			fs.Close();
		}

		
		public string[] nameArray()//判断已选择字典
		{
			string dictionoryFilePath;
			if(rbnMale.Checked)
			{
				dictionoryFilePath = @"./male.ini";
			}
			else if(rbnFemale.Checked)
			{
				dictionoryFilePath = @"./female.ini";
			}
			else
			{
				dictionoryFilePath = @"./custom.ini";
			}
			//获取字典文件内容
			string str;
			StreamReader sr = new StreamReader(dictionoryFilePath,false);
			str = sr.ReadToEnd();
			sr.Close();
			string[] singleNameArray = str.Split(',');
			return singleNameArray;//返回字符串数组
		}
		//生成按钮
		void BtnGenName1Click(object sender, EventArgs e)
		{
			string[] singleNameArray = nameArray();//获取字符串数组内容
			Random randomName = new Random();
			for(int i = 0;i<=numericUpDown1.Value+1;i++)//获取数量
			{
				textBox1.Text += String.Format("{0}{1}{2}{3}",txtLastname.Text,singleNameArray[randomName.Next(0,singleNameArray.Length)],singleNameArray[randomName.Next(0,singleNameArray.Length)],"、");
			}
		}
		//清空按钮
		void BtnClearClick(object sender, EventArgs e)
		{
			textBox1.Text = "";
		}
		//自定义字典提示
		void rbnCustomMouseEnter(object sender, EventArgs e)
		{
			ToolTip toolTip1 = new ToolTip();
			toolTip1.ShowAlways = true;
			toolTip1.SetToolTip(rbnCustom,"自定义字典在程序目录下的custom.ini，可用记事本打开，字与字之间以英文逗号“,”分隔。");
		}
		void toolTip1_Popup(object sender, PopupEventArgs e)
        {
 
        }

		
	}
}
