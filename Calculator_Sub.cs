using System;
using Xamarin.Forms;

namespace MyQPP_Final
{
	public class Calculator_Sub : CarouselPage
	{
		public Calculator_Sub()
		{
			var padding = new Thickness(0, Device.OnPlatform(40, 40, 0), 0, 0);

			var HelpPage = new ContentPage
			{

				Content = new StackLayout
				{
					Children = {





						new Label {
						Text = "This feature displays a breakdown of how the QPP Score is calculated.  " +
								"Examples of each compoent are also listed. " +
								"Navigate between the screens by swiping left and right",

						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center
					},


				}
				}
			};


			var qualityContentPage = new ContentPage
			{

				Content = new StackLayout
				{
					Children = {



						new Image {
						Source = "quality.png",
						WidthRequest = 150,
						HeightRequest = 150,

						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center
					},
								new Label {
						Text = "                                                               " +
								"                                                               " +
								"                                                                ",
								FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},


						new Label {
						Text = " -   Replaces PQRS and quality component of VM program",
						FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},

						new Label {
							Text = " -   Choose six measures (versus nine) measures",
							FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},

								new Label {
						Text = " -   One cross-cutting and one outcomes measure",
								FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},
				}
				}
			};
			var clinicalpracticeContentPage = new ContentPage
			{

				Content = new StackLayout
				{
					Children = {



						new Image {
						Source = "cpia.png",
						WidthRequest = 150,
						HeightRequest = 150,

						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center
					},
								new Label {
						Text = "                                                               " +
								"                                                               " +
								"                                                                ",
								FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},

							new Label {
						Text = " -   Replaces Medicare EHR Incentive Program",
						FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},

						new Label {
						Text = " -   Choose customizable measures that reflect EHR use",
							FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},

								new Label {
						Text = " -   Report as individual or group",
								FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},

				}
				}
			};
			var advancingcareContentPage = new ContentPage
			{

				Content = new StackLayout
				{
					Children = {



						new Image {
						Source = "ehr.png",
						WidthRequest = 150,
						HeightRequest = 150,

						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center
					},
								new Label {
						Text = "                                                               " +
								"                                                               " +
								"                                                                ",
								FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},


						new Label {
						Text = " -   Rewards practice improvement activities",
						FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},

						new Label {
						Text = " -   Choose from over 90 activities that suit practices' scope",
							FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},

								new Label {
							Text = " -   Full credit for PCMH acrreditation; partial credit for APM participation",
								FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},

				}
				}
			};


			var advancingcareContentPage2 = new ContentPage
			{


				Content = new StackLayout
				{
					Children = {



						new Image {
						Source = "ehr.png",
						WidthRequest = 75,
						HeightRequest = 75,

						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center
					},


						new Label {
							Text = " Six Objectives Make Up The Base Score",
						FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center,
							FontAttributes = FontAttributes.Bold,
					},
							new Label {
							Text = "(Max 50 Points)",
						FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center,
							FontAttributes = FontAttributes.Bold,
					},
						new Label {
						Text = "Protect Patient Health Information ",
							FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center,
								FontAttributes = FontAttributes.Bold,
					},


							new Label {
						Text = "Must report yes ",
							FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},

								new Label {
							Text = "Electronic Prescribing ",
								FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center,
								FontAttributes = FontAttributes.Bold,
					},

							new Label {
						Text = "Report a numerator and denominator" ,
							FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},


								new Label {
							Text = "Patient Electronic Access ",
								FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center,
								FontAttributes = FontAttributes.Bold,
					},

							new Label {
						Text = "Report a numerator and denominator" ,
							FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},


								new Label {
							Text = "Coordination of Care Through Patient Engagement ",
								FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center,
								FontAttributes = FontAttributes.Bold,
					},

							new Label {
						Text = "Report a numerator and denominator" ,
							FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},


								new Label {
							Text = "Health Information Exchange ",
								FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center,
								FontAttributes = FontAttributes.Bold,
					},

							new Label {
						Text = "Report a numerator and denominator" ,
							FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},
							new Label {
						Text = "Public Health and Clinical Data Registry Reporting ",
							FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center,
								FontAttributes = FontAttributes.Bold,
					},


							new Label {
						Text = "Must report yes ",
							FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},

				}
				}
			};


			var advancingcareContentPage3 = new ContentPage
			{


				Content = new StackLayout
				{
					Children = {



						new Image {
						Source = "ehr.png",
						WidthRequest = 100,
						HeightRequest = 100,

						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center
					},


						new Label {
							Text = " Three Pieces Make Up The Performance Score",
						FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center,
							FontAttributes = FontAttributes.Bold,
					},
						new Label {
							Text = "(Max 80 Points)",
						FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center,
							FontAttributes = FontAttributes.Bold,
					},

						new Label {
						Text = " - Patient Electronic Access ",
							FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center,
								FontAttributes = FontAttributes.Bold,
					},


								new Label {
							Text = " - Coordination of Care Through Patient Engagement ",
								FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center,
								FontAttributes = FontAttributes.Bold,
					},



								new Label {
							Text = " - Health Information Exchange ",
								FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center,
								FontAttributes = FontAttributes.Bold,
					},

									new Label {
							Text = " ---------------------------------------------------------",
								FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center,
								FontAttributes = FontAttributes.Bold,
					},
								new Label {
							Text = "If the base score and performance score combined is over 100",
						FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center,
							FontAttributes = FontAttributes.Bold,
					},

								new Label {
							Text = "The provider gets the full 25 points for the advancing care component",
						FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center,
							FontAttributes = FontAttributes.Bold,
					},



				}
				}
			};



			var resourceuseContentPage = new ContentPage
			{

				Content = new StackLayout
				{
					Children = {



						new Image {
						Source = "resourceuse.png",
						WidthRequest = 150,
						HeightRequest = 150,

						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center
					},

								new Label {
						Text = "                                                               " +
								"                                                               " +
								"                                                                ",
								FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},

							new Label {
						Text = " -   Replaces cost component of VM Program",
						FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},

						new Label {
						Text = " -   Calculates the score based on MC claims",
							FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},

								new Label {
						Text = " -   No reporting requirement for clinicians",
								FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
						HorizontalOptions = LayoutOptions.Start,
						VerticalOptions = LayoutOptions.Center
					},
				}
				}
			};

			Children.Add(HelpPage);
			Children.Add(qualityContentPage);
			Children.Add(clinicalpracticeContentPage);
			Children.Add(advancingcareContentPage);
			Children.Add(advancingcareContentPage2);
			Children.Add(advancingcareContentPage3);
			Children.Add(resourceuseContentPage);
		}
	}
}
