# UnityWebSockets
 
## Requirements:

Unity 2020.3.30f1 (LTS)
Python 3.10.2

## Python Dependencies:
asyncio==3.4.3
websockets==10.2
aioconsole==0.4.1

Steps to run the Demo Project:

## Start
- Download / Clone this project to your computer
- Extract the folder if necessary.

## Python:
- Within the project folder, navigate to `assets/PythonScripts`
- Using a Command Line application, install the dependencies in the `requirements.txt`
- Run the python server by using `python server.py`
- The console should say 'Waiting for Unity Connection'

## Unity:
- Open the project within Unity version 2020.3.30f1.
- Open the scene in `assets/Scenes/SampleScene`
- Ensuring that the Python server is running, press Play.
- In the Unity Console, it should say 'Connection Open!'

## Change Cube Color
- Go to the Python server, it should say 'Connection from Unity'
- Enter the color 'blue' and hit enter, the cube should turn blue in Unity
- You can use any HTML Color, or enter a Color's Hex code to change the color.
