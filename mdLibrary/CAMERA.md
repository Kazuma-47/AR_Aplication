# How does Camera Work?
if you havent added Vuforia to the unity project check the [Vuforia](VUFORIA.md) tutorial to set it up.  
here you can find:  
1. [How to setup the AR camera](#Setup)  
2. [Obtaining your license](#License)
3. [Connecting your Vuforia to Unity](#Connect)
4. [Detect Images](#AddImage)
5. [How does Image Targeting Work?](#ImageTarget)


<a name = "Setup"></a>
## how to setup Camera  
to setup the AR camera in the scene add a "AR Camera".  
![Adding the AR camera object](https://cdn.discordapp.com/attachments/643913270746677269/981493227607711794/unknown.png)  

<a name = "License"></a>
## Obtaining your Vuforia license.

to make sure you connect your vuforia project to your unity project you need to use your license.  
your license can be found on the website.  
Go to the Vuforia website and open the project you created.  
</br>
![license page](https://cdn.discordapp.com/attachments/643913270746677269/981507594143273041/unknown.png)  
</br>
Make sure to copy the license on the picture 

<a name= "Connect"></a>
## Connect your Vuforia project to your unity.  

to connect your unity to your vuforia project you need to paste the license you got from the website into your unity.  
Go to the AR camera and in the inspector go to the "Voforia Behaviour" component and open the configuration.  
</br>
![Unity Vuforia config](https://cdn.discordapp.com/attachments/643913270746677269/981505902031036426/unknown.png)  
</br>
After opening it paste the license from the website and it should be connected.  
</br>
![Add license](https://cdn.discordapp.com/attachments/643913270746677269/981513642388381736/unknown.png)  

<a name="AddImage"></a>
## How to Detect Images.  
Import the database package from the [vuforia](VUFORIA.md) tutorial.  
To detect images you need to add a "Image Target" object to the scene.
![Adding Image Object](https://cdn.discordapp.com/attachments/643913270746677269/981520614730919936/unknown.png)  
</br>

<a name = "ImageTarget"></a>
## How does the image target work?  
This is how the Image Target works:  
![Image Target](https://cdn.discordapp.com/attachments/643913270746677269/981527937645944852/unknown.png)  
</br>
|||
| ----------- | ----------- |
|Type| WHere Should the Image Target Import the database from|
|DataBase| Choose what database to use for the target one project can have more than 1 database of objects|
|Image Target|Target the Image in the database and trigger if u find it|

after making sure the settings are set. Give the "Image Target" a child object.  
This child object will be shown when the camera detects it.  
it can be anything from a button to a Image.
