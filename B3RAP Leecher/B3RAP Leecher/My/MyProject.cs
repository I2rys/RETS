using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace B3RAP_Leecher.My
{
	// Token: 0x02000004 RID: 4
	[StandardModule]
	[HideModuleName]
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	internal sealed class MyProject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000210C File Offset: 0x0000030C
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002128 File Offset: 0x00000328
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002144 File Offset: 0x00000344
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002160 File Offset: 0x00000360
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000217C File Offset: 0x0000037C
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000002 RID: 2
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000003 RID: 3
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000004 RID: 4
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000005 RID: 5
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x0200000C RID: 12
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			// Token: 0x060000AD RID: 173 RVA: 0x00007A20 File Offset: 0x00005C20
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				bool flag = Instance == null || Instance.IsDisposed;
				if (flag)
				{
					bool flag2 = MyProject.MyForms.m_FormBeingCreated != null;
					if (flag2)
					{
						bool flag3 = MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T));
						if (flag3)
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return Activator.CreateInstance<T>();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						});
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			// Token: 0x060000AE RID: 174 RVA: 0x00007B48 File Offset: 0x00005D48
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x060000AF RID: 175 RVA: 0x00007B5F File Offset: 0x00005D5F
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			// Token: 0x060000B0 RID: 176 RVA: 0x00007B6C File Offset: 0x00005D6C
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x060000B1 RID: 177 RVA: 0x00007B8C File Offset: 0x00005D8C
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x060000B2 RID: 178 RVA: 0x00007BA4 File Offset: 0x00005DA4
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x060000B3 RID: 179 RVA: 0x00007BC0 File Offset: 0x00005DC0
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060000B4 RID: 180 RVA: 0x00007BD8 File Offset: 0x00005DD8
			// (set) Token: 0x060000B8 RID: 184 RVA: 0x00007C44 File Offset: 0x00005E44
			public LeechOptions LeechOptions
			{
				[DebuggerHidden]
				get
				{
					this.m_LeechOptions = MyProject.MyForms.Create__Instance__<LeechOptions>(this.m_LeechOptions);
					return this.m_LeechOptions;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_LeechOptions)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<LeechOptions>(ref this.m_LeechOptions);
					}
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060000B5 RID: 181 RVA: 0x00007BF3 File Offset: 0x00005DF3
			// (set) Token: 0x060000B9 RID: 185 RVA: 0x00007C70 File Offset: 0x00005E70
			public Main Main
			{
				[DebuggerHidden]
				get
				{
					this.m_Main = MyProject.MyForms.Create__Instance__<Main>(this.m_Main);
					return this.m_Main;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Main)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Main>(ref this.m_Main);
					}
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060000B6 RID: 182 RVA: 0x00007C0E File Offset: 0x00005E0E
			// (set) Token: 0x060000BA RID: 186 RVA: 0x00007C9C File Offset: 0x00005E9C
			public MoreOptions MoreOptions
			{
				[DebuggerHidden]
				get
				{
					this.m_MoreOptions = MyProject.MyForms.Create__Instance__<MoreOptions>(this.m_MoreOptions);
					return this.m_MoreOptions;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_MoreOptions)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<MoreOptions>(ref this.m_MoreOptions);
					}
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060000B7 RID: 183 RVA: 0x00007C29 File Offset: 0x00005E29
			// (set) Token: 0x060000BB RID: 187 RVA: 0x00007CC8 File Offset: 0x00005EC8
			public SearchEngines SearchEngines
			{
				[DebuggerHidden]
				get
				{
					this.m_SearchEngines = MyProject.MyForms.Create__Instance__<SearchEngines>(this.m_SearchEngines);
					return this.m_SearchEngines;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SearchEngines)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SearchEngines>(ref this.m_SearchEngines);
					}
				}
			}

			// Token: 0x04000056 RID: 86
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			// Token: 0x04000057 RID: 87
			[EditorBrowsable(EditorBrowsableState.Never)]
			public LeechOptions m_LeechOptions;

			// Token: 0x04000058 RID: 88
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Main m_Main;

			// Token: 0x04000059 RID: 89
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MoreOptions m_MoreOptions;

			// Token: 0x0400005A RID: 90
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SearchEngines m_SearchEngines;
		}

		// Token: 0x0200000D RID: 13
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			// Token: 0x060000BC RID: 188 RVA: 0x00007CF4 File Offset: 0x00005EF4
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x060000BD RID: 189 RVA: 0x00007D14 File Offset: 0x00005F14
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x060000BE RID: 190 RVA: 0x00007D2C File Offset: 0x00005F2C
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x060000BF RID: 191 RVA: 0x00007D48 File Offset: 0x00005F48
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x00007D60 File Offset: 0x00005F60
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				bool flag = instance == null;
				T result;
				if (flag)
				{
					result = Activator.CreateInstance<T>();
				}
				else
				{
					result = instance;
				}
				return result;
			}

			// Token: 0x060000C1 RID: 193 RVA: 0x00007D89 File Offset: 0x00005F89
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x060000C2 RID: 194 RVA: 0x00007D93 File Offset: 0x00005F93
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		// Token: 0x0200000E RID: 14
		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060000C3 RID: 195 RVA: 0x00007DA0 File Offset: 0x00005FA0
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					bool flag = MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null;
					if (flag)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x060000C4 RID: 196 RVA: 0x00007DD2 File Offset: 0x00005FD2
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x0400005B RID: 91
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;
		}
	}
}
