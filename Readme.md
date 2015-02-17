#FxOSHelper
This library can be used to connect FxOS Apps to Microsoft Azure Mobile Service.

##Documentaiton

Install library from nuget

	Install-Package FxHelper

Edit App_Start\\WebApiConfig.cs. The paramater is [origin property of Firefox OS App](https://developer.mozilla.org/ja/Apps/Manifest#origin).

	public static void Register()
	{
	    ConfigOptions options = new ConfigOptions();
	            
	    HttpConfiguration config = ServiceConfig.Initialize(new ConfigBuilder(options));
	    // Add following tow rows.
	    config.SetCorsPolicyProviderFactory(new FxOSCorsPolicyFactory("app://fxos.contoso.com"));
	    config.EnableCors();
	
	    Database.SetInitializer(new MobileServiceInitializer());
	}
