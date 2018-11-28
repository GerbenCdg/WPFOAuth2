﻿namespace WpfOpenAuthTest
{
    using System.Windows;
    using DotNetOpenAuth.OAuth2;

    /// <summary>
    /// Interaction logic for Authorize2.xaml
    /// </summary>
    public partial class Authorize2 : Window {
		internal Authorize2(UserAgentClient client) {

			this.InitializeComponent();
			this.clientAuthorizationView.Client = client;
		}

		public IAuthorizationState Authorization {
			get { return this.clientAuthorizationView.Authorization; }
		}

		public ClientAuthorizationView ClientAuthorizationView {
			get { return this.clientAuthorizationView; }
		}

		private void clientAuthorizationView_Completed(object sender, ClientAuthorizationCompleteEventArgs e) {
			this.DialogResult = e.Authorization != null && e.Authorization.AccessToken != null;
			this.Close();
		}
	}
}