# ParksLocator Net Core Api

This Api is design to find the x amount of parks closest to your location given a zip code.

In order to allow to use this project without a database the data is hard coded in the ParkLocatorRepository. 

Request
Total - Amount of Parks, needs to be 10 or less (i hard coded 10 parks) bad practice.
ZipCode - Your Location or any place that you want to setup as start point.

Instruction
Run the Api
Paste the following url after the (localhost:port) /api/ParksLocator?ZipCode=40222&Total=5

I did not include all the validation needed just the minimum for time reasons.






