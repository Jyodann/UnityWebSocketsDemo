import asyncio
import websockets
from aioconsole import ainput

async def echo(websocket):
    # Get unity Version from Client:
    unity_version = await websocket.recv()

    print(f'Connection from Unity {unity_version}')
    while True: 
        msg = await ainput('Enter Colour: ')
        await websocket.send(msg)


async def main():
    print("Waiting for Unity Connection...")
    # Starts Webserver on port 8080:
    async with websockets.serve(echo, "localhost", 8080):
        await asyncio.Future()  # run forever

if __name__ == '__main__':
    asyncio.run(main())