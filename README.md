### cloud
vs.net 2013, Azure Websites, Azure Sql Database, (MongoLab soon)

A POC to show how multiple github.io sites and utilize one azure webapi/sql server/mongodb site. This is the webapi/sqlserver/mongodb project while cloud-one is the vs.net/angularjs site github.io site hitting it. Only sql server so far, will add mongo in the future, but that's no big deal.

The idea is to have the free msdn azure bucks support webapi serivces tied to sql server and free mongolab, then have multiple free github.io angular spas hitting the service. All would be free (with the $200/mo from msdn for azure).

##### web.config
I assume the the web.config file is the debug version, dis the web.debug.config file (use for qa?) and use web.release.config for prod. There's only two settings you'll have to address:

1. the connection string for debug/prod use
2. the CORS setting for local (*) or username.github.io

```xml
<configuration>
 <connectionStrings>
 	<add name="CloudServiceEntities" connectionString="..." providerName="..." />
 </connectionStrings>
</configuration>

<system.webServer>
	<httpProtocol>
		<customHeaders>
			<add name="Access-Control-Allow-Origin" value="*" />
		</customHeaders>
	</httpProtocol>
</system.webServer>
```

 
