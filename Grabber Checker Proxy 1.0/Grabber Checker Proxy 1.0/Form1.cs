using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reactive.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Grabber_Checker_Proxy_1._0.My;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.VisualBasic.CompilerServices;

namespace Grabber_Checker_Proxy_1._0
{
	// Token: 0x0200000F RID: 15
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00002B24 File Offset: 0x00000D24
		public Form1()
		{
			base.MouseDown += this.Form1_MouseDown;
			base.MouseMove += this.Form1_MouseMove;
			base.MouseUp += this.Form1_MouseUp;
			this.ActionList = new List<string>();
			this.SourcesCount = 0;
			this.InitializeComponent();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002B8C File Offset: 0x00000D8C
		private void Label2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002B98 File Offset: 0x00000D98
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			this.dragging = true;
			this.offset = e.Location;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002BB0 File Offset: 0x00000DB0
		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = this.dragging;
			if (flag)
			{
				Point point = base.PointToScreen(e.Location);
				base.Location = checked(new Point(point.X - this.offset.X, point.Y - this.offset.Y));
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002C0C File Offset: 0x00000E0C
		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			this.dragging = false;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002C18 File Offset: 0x00000E18
		private void Label3_MouseDown(object sender, MouseEventArgs e)
		{
			this.dragging = true;
			this.offset = e.Location;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002C30 File Offset: 0x00000E30
		private void Label3_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = this.dragging;
			if (flag)
			{
				Point point = base.PointToScreen(e.Location);
				base.Location = checked(new Point(point.X - this.offset.X, point.Y - this.offset.Y));
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002C8C File Offset: 0x00000E8C
		private void Label3_MouseUp(object sender, MouseEventArgs e)
		{
			this.dragging = false;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002C98 File Offset: 0x00000E98
		private void Button1_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					Form1._Closure$__18-1 CS$<>8__locals1 = new Form1._Closure$__18-1(CS$<>8__locals1);
					CS$<>8__locals1.$VB$Me = this;
					MySettingsProperty.Settings.isBusy = true;
					this.Button1.Text = "Stop...";
					this.Button1.Tag = "Alert";
					this.Button2.Enabled = false;
					this.Button3.Visible = false;
					this.Button4.Visible = false;
					this.ActionLabel.Text = "Grab...";
					this.ActionLabelTip.Text = "";
					this.StatLabel_Left.Text = "0";
					this.SourcesCount = 0;
					this.ActionList.Clear();
					CS$<>8__locals1.$VB$Local_sources = new List<string>();
					CS$<>8__locals1.$VB$Local_sources.Add("https://getfreeproxylists.blogspot.com");
					CS$<>8__locals1.$VB$Local_sources.Add("https://proxypedia.org");
					CS$<>8__locals1.$VB$Local_sources.Add("http://ksyushka.com/Proxy/US/r/Minnesota");
					CS$<>8__locals1.$VB$Local_sources.Add("https://free-proxy-list.net");
					CS$<>8__locals1.$VB$Local_sources.Add("https://proxylistdaily4you.blogspot.com/p/l1l2l3-proxy-server-list-1167.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://aliveproxy.com/anonymous-proxy-list");
					CS$<>8__locals1.$VB$Local_sources.Add("http://aliveproxy.com/ca-proxy-list");
					CS$<>8__locals1.$VB$Local_sources.Add("http://aliveproxy.com/de-proxy-list");
					CS$<>8__locals1.$VB$Local_sources.Add("http://aliveproxy.com/fastest-proxies");
					CS$<>8__locals1.$VB$Local_sources.Add("http://aliveproxy.com/fr-proxy-list");
					CS$<>8__locals1.$VB$Local_sources.Add("https://www.us-proxy.org");
					CS$<>8__locals1.$VB$Local_sources.Add("http://24h-sock.blogspot.co.uk");
					CS$<>8__locals1.$VB$Local_sources.Add("http://sslproxies24.blogspot.com");
					CS$<>8__locals1.$VB$Local_sources.Add("http://aliveproxy.com/high-anonymity-proxy-list");
					CS$<>8__locals1.$VB$Local_sources.Add("http://aliveproxy.com/jp-proxy-list");
					CS$<>8__locals1.$VB$Local_sources.Add("http://aliveproxy.com/proxy-list-port-3128");
					CS$<>8__locals1.$VB$Local_sources.Add("http://aliveproxy.com/proxy-list-port-80");
					CS$<>8__locals1.$VB$Local_sources.Add("http://aliveproxy.com/proxy-list-port-8000");
					CS$<>8__locals1.$VB$Local_sources.Add("http://aliveproxy.com/proxy-list-port-8080");
					CS$<>8__locals1.$VB$Local_sources.Add("http://aliveproxy.com/proxy-list-port-81");
					CS$<>8__locals1.$VB$Local_sources.Add("http://aliveproxy.com/ru-proxy-list");
					CS$<>8__locals1.$VB$Local_sources.Add("http://aliveproxy.com/socks4-list");
					CS$<>8__locals1.$VB$Local_sources.Add("http://aliveproxy.com/socks5-list");
					CS$<>8__locals1.$VB$Local_sources.Add("http://aliveproxy.com/transparent-proxy-list");
					CS$<>8__locals1.$VB$Local_sources.Add("http://aliveproxy.com/us-proxy-list");
					CS$<>8__locals1.$VB$Local_sources.Add("http://atomintersoft.com/anonymous_proxy_list");
					CS$<>8__locals1.$VB$Local_sources.Add("http://atomintersoft.com/high_anonymity_elite_proxy_list");
					CS$<>8__locals1.$VB$Local_sources.Add("http://atomintersoft.com/index.php?q=proxy_list_domain&domain=com");
					CS$<>8__locals1.$VB$Local_sources.Add("http://atomintersoft.com/products/alive-proxy/proxy-list");
					CS$<>8__locals1.$VB$Local_sources.Add("http://atomintersoft.com/products/alive-proxy/proxy-list/3128");
					CS$<>8__locals1.$VB$Local_sources.Add("http://atomintersoft.com/products/alive-proxy/proxy-list/high-anonymity");
					CS$<>8__locals1.$VB$Local_sources.Add("http://atomintersoft.com/products/alive-proxy/socks5-list");
					CS$<>8__locals1.$VB$Local_sources.Add("http://atomintersoft.com/proxy_list_domain");
					CS$<>8__locals1.$VB$Local_sources.Add("http://atomintersoft.com/proxy_list_domain_com");
					CS$<>8__locals1.$VB$Local_sources.Add("http://atomintersoft.com/proxy_list_domain_edu");
					CS$<>8__locals1.$VB$Local_sources.Add("http://atomintersoft.com/proxy_list_domain_net");
					CS$<>8__locals1.$VB$Local_sources.Add("http://atomintersoft.com/proxy_list_domain_org");
					CS$<>8__locals1.$VB$Local_sources.Add("http://atomintersoft.com/proxy_list_port");
					CS$<>8__locals1.$VB$Local_sources.Add("http://atomintersoft.com/proxy_list_port_3128");
					CS$<>8__locals1.$VB$Local_sources.Add("http://atomintersoft.com/proxy_list_port_80");
					CS$<>8__locals1.$VB$Local_sources.Add("http://atomintersoft.com/proxy_list_port_8000");
					CS$<>8__locals1.$VB$Local_sources.Add("http://atomintersoft.com/proxy_list_port_81");
					CS$<>8__locals1.$VB$Local_sources.Add("http://atomintersoft.com/transparent_proxy_list");
					CS$<>8__locals1.$VB$Local_sources.Add("http://best-proxy.com/english/search.php?search=anonymous-And-elite&country=any&type=anonymous-And-elite&port=any&ssl=any");
					CS$<>8__locals1.$VB$Local_sources.Add("http://best-proxy.com/english/search.php?search=anonymous-And-elite&country=any&type=anonymous-And-elite&port=any&ssl=any&p=2");
					CS$<>8__locals1.$VB$Local_sources.Add("http://best-proxy.com/english/search.php?search=anonymous-And-elite&country=any&type=anonymous-And-elite&port=any&ssl=any&p=3");
					CS$<>8__locals1.$VB$Local_sources.Add("http://cybersyndrome.net/");
					CS$<>8__locals1.$VB$Local_sources.Add("http://cybersyndrome.net/pla.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://cybersyndrome.net/pld.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://cybersyndrome.net/plr.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://cybersyndrome.net/search.cgi?q=CN");
					CS$<>8__locals1.$VB$Local_sources.Add("http://cybersyndrome.net/search.cgi?q=DE");
					CS$<>8__locals1.$VB$Local_sources.Add("http://cybersyndrome.net/search.cgi?q=FR");
					CS$<>8__locals1.$VB$Local_sources.Add("http://cybersyndrome.net/search.cgi?q=HK");
					CS$<>8__locals1.$VB$Local_sources.Add("http://cybersyndrome.net/search.cgi?q=US");
					CS$<>8__locals1.$VB$Local_sources.Add("http://freeproxy.ru/download/lists/goodproxy.txt");
					CS$<>8__locals1.$VB$Local_sources.Add("http://freeproxy.ru/download/lists/goodproxy.txt");
					CS$<>8__locals1.$VB$Local_sources.Add("http://getproxy.jp/en");
					CS$<>8__locals1.$VB$Local_sources.Add("http://getproxy.jp/en");
					CS$<>8__locals1.$VB$Local_sources.Add("http://getproxy.jp/en/?area=en");
					CS$<>8__locals1.$VB$Local_sources.Add("http://getproxy.jp/en/default/1");
					CS$<>8__locals1.$VB$Local_sources.Add("http://getproxy.jp/en/default/1");
					CS$<>8__locals1.$VB$Local_sources.Add("http://getproxy.jp/en/default/2");
					CS$<>8__locals1.$VB$Local_sources.Add("http://getproxy.jp/en/default/2");
					CS$<>8__locals1.$VB$Local_sources.Add("http://getproxy.jp/en/default/3");
					CS$<>8__locals1.$VB$Local_sources.Add("http://getproxy.jp/en/default/3");
					CS$<>8__locals1.$VB$Local_sources.Add("http://getproxy.jp/en/default/4");
					CS$<>8__locals1.$VB$Local_sources.Add("http://getproxy.jp/en/default/4");
					CS$<>8__locals1.$VB$Local_sources.Add("http://getproxy.jp/en/default/5");
					CS$<>8__locals1.$VB$Local_sources.Add("http://getproxy.jp/en/default/5");
					CS$<>8__locals1.$VB$Local_sources.Add("http://getproxy.jp/en/fastest");
					CS$<>8__locals1.$VB$Local_sources.Add("http://ip-adress.com/proxy_list/?k=time&d=desc");
					CS$<>8__locals1.$VB$Local_sources.Add("http://ipaddress.com/proxy-list/");
					CS$<>8__locals1.$VB$Local_sources.Add("http://irc-proxies24.blogspot.com/feeds/posts/default");
					CS$<>8__locals1.$VB$Local_sources.Add("http://my-proxy.com/free-proxy-list-10.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://my-proxy.com/free-proxy-list-2.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://my-proxy.com/free-proxy-list-3.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://my-proxy.com/free-proxy-list-4.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://my-proxy.com/free-proxy-list-5.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://my-proxy.com/free-proxy-list-6.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://my-proxy.com/free-proxy-list-7.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://my-proxy.com/free-proxy-list-8.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://my-proxy.com/free-proxy-list-9.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://my-proxy.com/free-proxy-list.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://newfreshproxies24.blogspot.com/feeds/posts/default");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-01.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-02.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-03.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-04.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-05.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-06.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-07.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-08.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-09.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-10.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-11.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-12.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-13.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-14.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-15.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-16.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-17.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-18.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-19.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-20.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-21.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-22.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-23.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-24.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-25.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-26.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-27.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-28.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-29.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://nntime.com/proxy-list-30.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://notan.h1.ru/hack/xwww/proxy1.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://notan.h1.ru/hack/xwww/proxy2.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://notan.h1.ru/hack/xwww/proxy3.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://notan.h1.ru/hack/xwww/proxy4.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://notan.h1.ru/hack/xwww/proxy5.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://notan.h1.ru/hack/xwww/proxy6.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://notan.h1.ru/hack/xwww/proxy7.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://notan.h1.ru/hack/xwww/proxy8.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://notan.h1.ru/hack/xwww/proxy9.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://notan.h1.ru/hack/xwww/proxy10.html");
					CS$<>8__locals1.$VB$Local_sources.Add("https://orca.tech/?action=real-time-proxy-list");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxy-ip-list.com/");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxy.ipcn.org/proxylist.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxy.ipcn.org/proxylist2.html");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxy24update.blogspot.com/feeds/posts/default");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=1");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=2");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=3");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=3");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=4");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=4");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=5");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=5");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=6");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=6");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=7");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=7");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=8");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=8");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=9");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=9");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=10");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=10");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=11");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=11");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=12");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=12");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=13");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=13");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=14");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=14");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=15");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=15");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=16");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=17");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=18");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=19");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=20");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=21");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=22");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=23");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=24");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=25");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=26");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=27");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=28");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=29");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=30");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=31");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=32");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=33");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=34");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=35");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=36");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=37");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=38");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=39");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylistchecker.org/proxylists.php?t=&p=40");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylists.net/");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylists.net/http_highanon.txt");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxylists.net/socks4.txt");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxysearcher.sourceforge.net/Proxy%20List.php?type=http");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxysearcher.sourceforge.net/Proxy%20List.php?type=socks");
					CS$<>8__locals1.$VB$Local_sources.Add("http://proxyserverlist-24.blogspot.com/feeds/posts/default");
					CS$<>8__locals1.$VB$Local_sources.Add("http://ps.givemehacks.com/proxies.txt");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-01.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-02.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-03.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-04.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-05.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-06.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-07.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-08.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-09.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-10.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-11.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-12.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-13.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-14.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-15.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-16.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-17.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-18.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-19.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-20.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-21.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-22.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-23.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-24.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-25.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-26.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-27.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-28.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-29.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/proxy-30.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/socks01.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/socks02.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/socks03.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/socks04.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://samair.ru/proxy/socks05.htm");
					CS$<>8__locals1.$VB$Local_sources.Add("http://socks24.org/feeds/posts/default");
					CS$<>8__locals1.$VB$Local_sources.Add("http://socks24.ru/proxy/httpProxies.txt");
					CS$<>8__locals1.$VB$Local_sources.Add("http://socksproxylist24.blogspot.com/feeds/posts/default");
					CS$<>8__locals1.$VB$Local_sources.Add("http://spys.ru/en");
					CS$<>8__locals1.$VB$Local_sources.Add("http://spys.ru/en/socks-proxy-list");
					CS$<>8__locals1.$VB$Local_sources.Add("http://spys.ru/en/socks-proxy-list/1");
					CS$<>8__locals1.$VB$Local_sources.Add("http://sslproxies24.blogspot.com/feeds/posts/default");
					CS$<>8__locals1.$VB$Local_sources.Add("http://txt.proxyspy.net/proxy.txt");
					CS$<>8__locals1.$VB$Local_sources.Add("http://vip-socks24.blogspot.com/feeds/posts/default");
					CS$<>8__locals1.$VB$Local_sources.Add("http://vipsocks24.net/feeds/posts/default");
					CS$<>8__locals1.$VB$Local_sources.Add("http://eng.fineproxy.org/freshproxy/");
					CS$<>8__locals1.$VB$Local_sources.Add("http://www.megaproxylist.net/");
					HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://orca.tech/community-proxy-list/");
					httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36";
					httpWebRequest.Timeout = 3500;
					httpWebRequest.ReadWriteTimeout = 1500;
					httpWebRequest.KeepAlive = false;
					try
					{
						using (StreamReader streamReader = new StreamReader(httpWebRequest.GetResponse().GetResponseStream()))
						{
							MatchCollection matchCollection = new Regex("<a href='([^']*)'").Matches(streamReader.ReadToEnd());
							int num = 0;
							try
							{
								foreach (object obj in matchCollection)
								{
									Match match = (Match)obj;
									bool flag = num != MySettingsProperty.Settings.OrcaSourceMax & !CS$<>8__locals1.$VB$Local_sources.Contains("https://orca.tech/community-proxy-list/" + match.Groups[1].Value);
									if (flag)
									{
										CS$<>8__locals1.$VB$Local_sources.Add("https://orca.tech/community-proxy-list/" + match.Groups[1].Value);
										num++;
									}
									else
									{
										bool flag2 = num == MySettingsProperty.Settings.OrcaSourceMax;
										if (flag2)
										{
											break;
										}
									}
								}
							}
							finally
							{
								IEnumerator enumerator;
								if (enumerator is IDisposable)
								{
									(enumerator as IDisposable).Dispose();
								}
							}
						}
					}
					catch (WebException ex)
					{
						Console.WriteLine("Error with Orca! " + ex.Response);
					}
					List<string> source = CS$<>8__locals1.$VB$Local_sources.OrderBy((Form1._Closure$__.$I18-0 == null) ? (Form1._Closure$__.$I18-0 = ((string a) => Guid.NewGuid())) : Form1._Closure$__.$I18-0).ToList<string>();
					ThreadPool.SetMinThreads(MySettingsProperty.Settings.GrabberThreads, MySettingsProperty.Settings.GrabberThreads);
					ServicePointManager.MaxServicePointIdleTime = 8000;
					ServicePointManager.DefaultConnectionLimit = (int)Math.Round((double)MySettingsProperty.Settings.GrabberThreads / 3.0);
					var source2 = source.ToObservable<string>().SelectMany(delegate(string s)
					{
						Form1._Closure$__18-0 CS$<>8__locals2 = new Form1._Closure$__18-0(CS$<>8__locals2);
						CS$<>8__locals2.$VB$Me = this;
						CS$<>8__locals2.$VB$Local_s = s;
						return Observable.Start(() => new
						{
							source = CS$<>8__locals2.$VB$Local_s,
							grab = CS$<>8__locals2.$VB$Me.GrabProxies(CS$<>8__locals2.$VB$Local_s)
						});
					}).Select((Form1._Closure$__.$I18-3 == null) ? (Form1._Closure$__.$I18-3 = (x => new
					{
						x.source,
						x.grab
					})) : Form1._Closure$__.$I18-3).ObserveOn(this).Do(delegate(a0)
					{
						base._Lambda$__4(a0);
					});
					source2.ToArray().ObserveOn(this).Subscribe(delegate(a0)
					{
						this._Lambda$__18-5(a0);
					});
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004008 File Offset: 0x00002208
		private bool GrabProxies(string source)
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(source);
				httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36";
				httpWebRequest.Timeout = 3500;
				httpWebRequest.ReadWriteTimeout = 1500;
				httpWebRequest.KeepAlive = false;
				try
				{
					using (StreamReader streamReader = new StreamReader(httpWebRequest.GetResponse().GetResponseStream()))
					{
						MatchCollection matchCollection = new Regex("[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}:[0-9]{1,4}").Matches(streamReader.ReadToEnd());
						try
						{
							IEnumerator enumerator = matchCollection.GetEnumerator();
							while (enumerator.MoveNext())
							{
								Form1._Closure$__19-0 CS$<>8__locals1 = new Form1._Closure$__19-0(CS$<>8__locals1);
								CS$<>8__locals1.$VB$Me = this;
								CS$<>8__locals1.$VB$Local_proxy = (Match)enumerator.Current;
								bool flag = !this.ActionList.Contains(CS$<>8__locals1.$VB$Local_proxy.ToString());
								if (flag)
								{
									base.Invoke(new MethodInvoker(delegate()
									{
										base._Lambda$__0();
									}));
								}
							}
						}
						finally
						{
							IEnumerator enumerator;
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
					}
					return true;
				}
				catch (WebException ex)
				{
					Console.WriteLine("Error: " + source + " " + ex.Response);
					return false;
				}
				finally
				{
					base.Invoke(new MethodInvoker(delegate()
					{
						this._Lambda$__19-1();
					}));
				}
			}
			catch (Exception ex2)
			{
			}
			return false;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000041F0 File Offset: 0x000023F0
		private void Button2_Click(object sender, EventArgs e)
		{
			bool flag = !MySettingsProperty.Settings.isBusy;
			if (flag)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Multiselect = false;
				bool flag2 = openFileDialog.ShowDialog() == DialogResult.OK & openFileDialog.CheckFileExists;
				if (flag2)
				{
					MySettingsProperty.Settings.isBusy = true;
					this.Button2.Text = "Stop...";
					this.Button2.Tag = "Alert";
					this.Button3.Visible = false;
					this.Button1.Enabled = false;
					string[] collection = new Regex("[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}:[0-9]{1,4}").Matches(File.ReadAllText(openFileDialog.FileName)).OfType<Match>().Select((Form1._Closure$__.$I20-0 == null) ? (Form1._Closure$__.$I20-0 = ((Match x) => x.ToString())) : Form1._Closure$__.$I20-0).ToArray<string>();
					this.ActionList.Clear();
					this.ActionList.AddRange(collection);
					this.CheckProxies();
				}
			}
			else
			{
				MySettingsProperty.Settings.StopFunction = true;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004300 File Offset: 0x00002500
		private bool CheckProxies()
		{
			MySettingsProperty.Settings.isBusy = true;
			this.ActionLabel.Text = "Checking...";
			this.ActionLabelTip.Text = "";
			this.StatLabel_Left.Text = "0";
			this.StatLabel_Left.Text = "0";
			this.SourcesCount = 0;
			int CheckCount = 0;
			int ValidCount = 0;
			ThreadPool.SetMinThreads(MySettingsProperty.Settings.CheckerThreads, MySettingsProperty.Settings.CheckerThreads);
			ServicePointManager.MaxServicePointIdleTime = 8000;
			ServicePointManager.DefaultConnectionLimit = checked((int)Math.Round((double)MySettingsProperty.Settings.CheckerThreads / 3.0));
			IObservable<string> source = (from x in this.ActionList.ToObservable<string>().SelectMany((string p) => Observable.Start(() => new
			{
				proxy = p,
				check = this.CheckProxy(p)
			})).Do(delegate(a0)
			{
				base._Lambda$__2(a0);
			})
			select new
			{
				proxy = x.proxy,
				check = x.check,
				CheckCount = CheckCount,
				ValidCount = ValidCount
			}).ObserveOn(this).Do(delegate(a0)
			{
				this._Lambda$__21-4(a0);
			}).Where((Form1._Closure$__.$I21-5 == null) ? (Form1._Closure$__.$I21-5 = (x => x.check)) : Form1._Closure$__.$I21-5).Select((Form1._Closure$__.$I21-6 == null) ? (Form1._Closure$__.$I21-6 = (x => x.proxy)) : Form1._Closure$__.$I21-6);
			source.ToArray<string>().ObserveOn(this).Subscribe(delegate(string[] a0)
			{
				this._Lambda$__21-7(a0);
			});
			return true;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004494 File Offset: 0x00002694
		private bool CheckProxy(string proxy)
		{
			bool flag = !MySettingsProperty.Settings.StopFunction;
			if (flag)
			{
				base.Invoke(new MethodInvoker(delegate()
				{
					this.ActionLabelTip.Text = proxy;
				}));
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://azenv.net");
				httpWebRequest.Timeout = 4500;
				httpWebRequest.ReadWriteTimeout = 2500;
				httpWebRequest.KeepAlive = false;
				httpWebRequest.Proxy = new WebProxy(proxy);
				try
				{
					using ((HttpWebResponse)httpWebRequest.GetResponse())
					{
						return true;
					}
				}
				catch (Exception ex)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004574 File Offset: 0x00002774
		private bool Export()
		{
			bool result;
			try
			{
				bool flag = this.ActionList.Count > 0;
				bool flag5;
				if (flag)
				{
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					saveFileDialog.FileName = "Proxy - " + (checked((int)Math.Round((DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds))).ToString();
					saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
					saveFileDialog.FilterIndex = 1;
					saveFileDialog.RestoreDirectory = true;
					bool flag2 = saveFileDialog.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
						{
							this.ActionList.Sort();
							object obj = this.ActionList.Distinct<string>().ToArray<string>();
							bool flag3 = Form1.p__0 == null;
							if (flag3)
							{
								Form1.p__0 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(Form1)));
							}
							IEnumerator enumerator = Form1.p__0.Target(Form1.p__0, RuntimeHelpers.GetObjectValue(obj)).GetEnumerator();
							while (enumerator.MoveNext())
							{
								bool flag4 = Form1.p__1 == null;
								if (flag4)
								{
									Form1.p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Form1)));
								}
								string text = Form1.p__1.Target(Form1.p__1, RuntimeHelpers.GetObjectValue(enumerator.Current));
								streamWriter.WriteLine(text.Replace("\r", "").Replace("\n", "").ToString());
							}
						}
						this.ActionList.Clear();
						flag5 = true;
					}
					else
					{
						flag5 = false;
					}
				}
				else
				{
					MessageBox.Show("Nothing to Export.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					flag5 = false;
				}
				result = flag5;
			}
			catch (Exception ex)
			{
			}
			return result;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000047B0 File Offset: 0x000029B0
		private void Button3_Click(object sender, EventArgs e)
		{
			this.Export();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000047BC File Offset: 0x000029BC
		private void Button4_Click(object sender, EventArgs e)
		{
			this.Export();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000047C8 File Offset: 0x000029C8
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.facebook.com/groups/185383492115208/");
			Process.Start("http://www.youtube.com/c/AlphaCrackTMPermium");
			Process.Start("https://discordapp.com/invite/C6Wvtg7");
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000047EC File Offset: 0x000029EC
		private void ActionLabel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000055BC File Offset: 0x000037BC
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000055C8 File Offset: 0x000037C8
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000055D4 File Offset: 0x000037D4
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000055E0 File Offset: 0x000037E0
		internal virtual Label Label2
		{
			[CompilerGenerated]
			get
			{
				return this._Label2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label2_Click);
				Label label = this._Label2;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label2 = value;
				label = this._Label2;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00005624 File Offset: 0x00003824
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00005630 File Offset: 0x00003830
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000563C File Offset: 0x0000383C
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00005648 File Offset: 0x00003848
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00005654 File Offset: 0x00003854
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00005660 File Offset: 0x00003860
		internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000566C File Offset: 0x0000386C
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00005678 File Offset: 0x00003878
		internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00005684 File Offset: 0x00003884
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00005690 File Offset: 0x00003890
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000056D4 File Offset: 0x000038D4
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000056E0 File Offset: 0x000038E0
		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00005724 File Offset: 0x00003924
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00005730 File Offset: 0x00003930
		internal virtual ProgressBar ProgressBar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000573C File Offset: 0x0000393C
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00005748 File Offset: 0x00003948
		internal virtual Label ActionLabel
		{
			[CompilerGenerated]
			get
			{
				return this._ActionLabel;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ActionLabel_Click);
				Label actionLabel = this._ActionLabel;
				if (actionLabel != null)
				{
					actionLabel.Click -= value2;
				}
				this._ActionLabel = value;
				actionLabel = this._ActionLabel;
				if (actionLabel != null)
				{
					actionLabel.Click += value2;
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000578C File Offset: 0x0000398C
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00005798 File Offset: 0x00003998
		internal virtual Label StatLabel_Left { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000057A4 File Offset: 0x000039A4
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000057B0 File Offset: 0x000039B0
		internal virtual Label StatLabel_Right { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000057BC File Offset: 0x000039BC
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000057C8 File Offset: 0x000039C8
		internal virtual Label ActionLabelTip { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000057D4 File Offset: 0x000039D4
		// (set) Token: 0x0600007D RID: 125 RVA: 0x000057E0 File Offset: 0x000039E0
		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button3_Click);
				Button button = this._Button3;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00005824 File Offset: 0x00003A24
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00005830 File Offset: 0x00003A30
		internal virtual Label Label3
		{
			[CompilerGenerated]
			get
			{
				return this._Label3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.Label3_MouseDown);
				MouseEventHandler value3 = new MouseEventHandler(this.Label3_MouseMove);
				MouseEventHandler value4 = new MouseEventHandler(this.Label3_MouseUp);
				Label label = this._Label3;
				if (label != null)
				{
					label.MouseDown -= value2;
					label.MouseMove -= value3;
					label.MouseUp -= value4;
				}
				this._Label3 = value;
				label = this._Label3;
				if (label != null)
				{
					label.MouseDown += value2;
					label.MouseMove += value3;
					label.MouseUp += value4;
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000058AC File Offset: 0x00003AAC
		// (set) Token: 0x06000081 RID: 129 RVA: 0x000058B8 File Offset: 0x00003AB8
		internal virtual Button Button4
		{
			[CompilerGenerated]
			get
			{
				return this._Button4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button4_Click);
				Button button = this._Button4;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button4 = value;
				button = this._Button4;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000058FC File Offset: 0x00003AFC
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00005908 File Offset: 0x00003B08
		internal virtual PictureBox PictureBox1
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox1_Click);
				PictureBox pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox1 = value;
				pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x04000018 RID: 24
		private bool dragging;

		// Token: 0x04000019 RID: 25
		private Point offset;

		// Token: 0x0400001A RID: 26
		private List<string> ActionList;

		// Token: 0x0400001B RID: 27
		private int SourcesCount;

		// Token: 0x0400001C RID: 28
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400001D RID: 29
		public const int HT_CAPTION = 2;

		// Token: 0x0400001E RID: 30
		private bool m_aeroEnabled;

		// Token: 0x0400001F RID: 31
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000020 RID: 32
		private const int WM_NCPAINT = 133;

		// Token: 0x04000021 RID: 33
		private const int WM_ACTIVATEAPP = 28;

		// Token: 0x04000022 RID: 34
		public static CallSite<Func<CallSite, object, IEnumerable>> p__0;

		// Token: 0x04000023 RID: 35
		public static CallSite<Func<CallSite, object, string>> p__1;
	}
}
