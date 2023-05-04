 ____ ____ ____ ____ ____ ____ ____ ____                                                                                                                    
||R |||o |||s |||e |||s |||a |||m |||s ||                                                                                                                   
||__|||__|||__|||__|||__|||__|||__|||__||                                                                                                                   
|/__\|/__\|/__\|/__\|/__\|/__\|/__\|/__\|                                                                                                                   
 ____ ____ ____ ____ ____ ____ ____ ____ ____ ____ _________ ____ ____ ____ ____ ____ _________ ____ ____ ____ ____ ____ ____ ____ ____ ____ ____ ____ ____ 
||M |||o |||t |||o |||b |||r |||i |||d |||g |||e |||       |||A |||l |||i |||a |||s |||       |||C |||o |||n |||f |||i |||g |||u |||r |||a |||t |||o |||r ||
||__|||__|||__|||__|||__|||__|||__|||__|||__|||__|||_______|||__|||__|||__|||__|||__|||_______|||__|||__|||__|||__|||__|||__|||__|||__|||__|||__|||__|||__||
|/__\|/__\|/__\|/__\|/__\|/__\|/__\|/__\|/__\|/__\|/_______\|/__\|/__\|/__\|/__\|/__\|/_______\|/__\|/__\|/__\|/__\|/__\|/__\|/__\|/__\|/__\|/__\|/__\|/__\|



CSV Format for both Radio ID and Talkgroup ID

ID,Alias


To use:
export/create CSV files elsewere
#NOTE: TALKGROUPS AND RADIO IDS NEED TO BE ON SEPREATE CSV FILES!
select openCSV under Talkgroup input
![alt text](https://imgur.com/a/SHtrVfT)
select openCSV under Radio ID input
![alt text](https://imgur.com/a/RxiqYMW)
select open TXT under Output
![alt text](https://imgur.com/a/E9bUGlH)
Check the Talkgroup checkbox if you have selected a Talkgroup CSV and wish to have talkgroups added to the alias output
![alt text](https://imgur.com/a/jLgyHgI)
Verify all paths and file names. Then hit generate
![alt text](https://imgur.com/a/NQ0qdkx)
The program is complete if the status box turns green and the word "count" turns into a non negitive number
![alt text](https://imgur.com/a/jUKZZdX)

To Upload:
Open and log into Motobridge MRGU G1-G4 CT

Right Click the resource you wish to upload the alias file to, and select Radio Alias Database
![alt text](https://imgur.com/a/FMGq7pi)
![alt text](https://imgur.com/a/Skc8mDS)
Click Read and open the outputed .txt file
![alt text](https://imgur.com/a/Jdzr9OJ)
Once done click apply
![alt text](https://imgur.com/a/slFXhyS)

IF Alias's dont populate, or Dispatch position cant be shut down:
Inside the DA (Local DA or Software Only DA) click the small radio tower icon on the resource box, Then select Request Alias Database
![alt text](https://imgur.com/a/QhP8Uei)
