# GCS Phoenix

GCS Phoenix is a ground control station application for managing and monitoring rocket flights. This application provides functionalities such as real-time mapping, serial port communication, and data visualization.

## Features

- **Real-time Mapping**: Utilizes GMap.NET to display real-time satellite imagery and add markers on the map.
- **Serial Port Communication**: Allows communication with external devices through serial ports.
- **Data Visualization**: Visualizes data from sensors such as accelerometers and altitude sensors.

## Installation

1. Clone or download the repository.
2. Open the solution file (`GCS_Phoenix.sln`) in Visual Studio.
3. Build the solution to resolve dependencies.
4. Run the application.

## Usage

### Map

- The map is displayed using GMap.NET.
- Use the controls to navigate and zoom in/out.
- Markers are added to the map to represent specific locations.

### Serial Port

- Select the appropriate serial port and baud rate from the dropdown menus (errors will pop-up if the connection is unsuccesful).
- Click the "Connect" button to establish a connection.
- Received data from the serial port will be displayed in the `serialDataBox`.
- `Sp_DataReceived` is called everytime the serial port receives a packet.
- With protobuf, the first byte represents the number or remaining bytes in the transmission, so the total size of the message is the first byte + 1.

### Protobuf

- Make sure to have the same `.proto` file on tthe rocket avionics and the ground station.
- Create the C# class using the protobuf compiler and the `.proto` file.
- Use the `Message.Parser.ParseDelemitedFrom(stream)` method to limit decoding errors (the method will ignore packets that are not part of the message).

### Data Visualization

- Accelerometer and altitude data are visualized using ScottPlot.
- The plots show data over time.

## Configuration

- Cache location for map tiles can be configured in `InitializeMap` method in `Form1.cs`.
- Default serial port settings can be configured in the `InitializeComPort` method in `Form1.cs`.
- Axis limits and plot styles can be configured in the `Form1_Load` method in `Form1.cs`.


## License

This project is licensed under the [MIT License].

## Acknowledgements

- [GMap.NET](https://github.com/radioman/greatmaps) - for the mapping library.
- [ScottPlot](https://github.com/ScottPlot/ScottPlot) - for the data visualization library.
- [LEDBulb](https://github.com/A9G-Data-Droid/LEDBulb) - for the status indicatiors
- [Protobuf](https://github.com/protocolbuffers/protobuf) - for the protobuf communications
