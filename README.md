Rosesams Motobridge Alias Configurator
===============

### CSV Format for both Radio ID and Talkgroup ID

ID,Alias


### To use:
export/create CSV files elsewere
**NOTE: TALKGROUPS AND RADIO IDS NEED TO BE ON SEPREATE CSV FILES!**

select openCSV under Talkgroup input

![alt text](https://i.imgur.com/C6uC9wh.png)

select openCSV under Radio ID input

![alt text](https://i.imgur.com/zs4ClRA.png)

select open TXT under Output

![alt text](https://i.imgur.com/Imx1E0g.png)

Check the Talkgroup checkbox if you have selected a Talkgroup CSV and wish to have talkgroups added to the alias output

![alt text](https://i.imgur.com/mEoYOv1.png)

Verify all paths and file names. Then hit generate

![alt text](https://i.imgur.com/5AIRyCg.png)

The program is complete if the status box turns green and the word "count" turns into a non negitive number

![alt text](https://i.imgur.com/qxyTp0H.png)


### To Upload:
Open and log into Motobridge MRGU G1-G4 CT

Right Click the resource you wish to upload the alias file to, and select Radio Alias Database

![alt text](https://i.imgur.com/YWixqMm.jpg)
![alt text](https://i.imgur.com/Q2hxVc7.jpeg)

Click Read and open the outputed .txt file

![alt text](https://i.imgur.com/YTsgbgy.png)

Once done click apply

![alt text](https://i.imgur.com/7I9XJrs.png)

IF Alias's dont populate, or Dispatch position cant be shut down:
Inside the DA (Local DA or Software Only DA) click the small radio tower icon on the resource box, Then select Request Alias Database

![alt text](https://i.imgur.com/mcbT24S.jpeg)
