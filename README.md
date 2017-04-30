# Potota
Portable Autonomous Vehicle with Traxxas Summit

## Overview ##
The Potota vehicle is a semi-autonomous remote controlled vehicle that is compatible with Traxxas Summit and other PWM servo based vehicles. The codes are written by Team 5 Stars, which is one of the groups in Purdue ECET 270 course including Dominick Lee, Luigi Moca, Atusunje Farai Kawatira, Harry Mo, and Tian Tian Ye.

## Programming Languages ##
The codes provided are based on programming in Arduino, Visual Basic .NET, and NodeJS.

## System ##
The system comprises of the following parts working simultaneously:<br />
<ul>
<li>Intelligent Remote Control with Nextion Display (MCU)</li>
<li>Engine Control Unit (ECU) and RF transceiver (MCU)</li>
<li>Ultrasonic Sensor Array (MCU)</li>
<li>Sweeping Lidar (MCU)</li>
<li>Speed Sensor and Line Follower (MCU)</li>
<li>Windows Tablet Application for Streaming and Logging (VB.NET)</li>
<li>Web Streaming via NodeJS on an EC2 Instance</li>
</ul>

## Purpose of components ##
<p><strong>Intelligent Remote Control (MCU)</strong> allows the user to control the vehicle and its various autonomous functions. It includes a fingerprint sensor that can store up to 200 fingerprints and verify them in a matter of seconds. This can be used to authorize users to drive the vehicle. The remote also has a Nextion touchscreen display with a custom interface for selecting the mode of the vehicle as well as switching the gears and front/back wheel drives. Finally, the remote has a long distance low-latency transceiver that communicates directly to the vehicle all messages that are relayed from the user including realtime joystick interactions.</p>
<p><strong>Engine Control Unit (ECU) and RF transceiver (MCU)</strong> handles the communication between the vehicle and remote. Also, it handles to control of the motors via 5 servo channels. It allows the vehicle to be controlled by other blocks.</p>
<p><strong>Ultrasonic Sensor Array (MCU)</strong> allows the vehicle to detect the presence of obstacles and people within the proximity of the vehicle. The vehicle has 4 mounted sonar sensors with a front sensor (s1), rear sensor (s2), left sensor (s3), and right sensor (s4) where each sensor can detect the distance from the nearest object with a unit of centimeters or inches.</p>
<p><strong>Sweeping Lidar (MCU)</strong> handles the precise detection of objects in front of the vehicle so that it can avoid collisions while traveling at high speeds.</p>
<p><strong>Speed Sensor and Line Follower (MCU)</strong> the speed sensor tracks the speed of the vehicle and provides this information via serial. Additionally, the same MCU acquires data from a line following sensor and controls the servo that adjusts the height of the sensor.</p>
<p><strong>Windows Tablet Application for Streaming and Logging (VB.NET)</strong> provides a central control platform that combines all the microcontrollers and acquires the data from the sensors as well as determine the output given to the ECU. Essentially, this provides a method for the user to interact and a method to stream all the sensor data through the web. The application also logs all the vehicle data to a CSV file for later retrieval.</p>
<p><strong>Web Streaming via NodeJS on an EC2 Instance</strong> provides the user a realtime chart (using ChartJS) for the visualizations for the car's status. The Windows Tablet Application uses NodeJS to relay the sensor data to the web. This realtime data can be accessed on a mobile app.</p>
</ul>
