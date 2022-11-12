# IEC61850
 
This Repository come from a 2-months project realized as part of my study at the Université de Technologie de Belfort Montbéliard with Hugo Téani.
The goal was to find and use a library in order to monitor IEC61850 Relays.
Special thanks to MZ Automation (https://libiec61850.com/) for the initial library. They propose to code the IEC 61850 application for their customers. Feel free to check their website.
Unfortunately, the Goose message listener wasn't working. 
That's why I had to fully modify it in order to create a Windows DLL so that it can communicate with the C# App

The app is able to connect to IEDs, catch and manage Goose messages. 

All the info (how to use and modify it) are available in the french report that we made for the notation of the project. 
A further version would be to monitor the Sample Values.

You can easily edit this project for your needs with the details in the report. Please feel free to contact me if you need any information.
