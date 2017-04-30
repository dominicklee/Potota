#include <Wire.h>
#include <Servo.h> 
#define uchar unsigned char

Servo myservo;

void initSensor(void);
void updateSensor(void);

int t;        //byte index
int data[16];  //line follower sensor data
int pos = 0;    // variable to store the servo position 

//speed code
volatile int rpmcount = 0;
long int rpm = 0, mph = 0;
unsigned long lastmillis = 0;
const double diameter = 0.5729167;

void setup()
{
  Wire.begin();        // join i2c bus (address optional for master)
  Serial.begin(9600);  // start serial for output
  myservo.attach(9);  // attaches the servo on pin 9 to the servo object 
  t = 0;
  initSensor();
  
  attachInterrupt(0, rpm_fan, FALLING);//interrupt cero (0) is on pin two(2)
}

void loop()
{
  updateSensor();
  /*
  Serial.print("data[0]:");
  Serial.println(data[0]);
  Serial.print("data[2]:");
  Serial.println(data[2]);
  Serial.print("data[4]:");
  Serial.println(data[4]);
  Serial.print("data[6]:");
  Serial.println(data[6]);
  Serial.print("data[8]:");
  Serial.println(data[8]);
  Serial.print("data[10]:");
  Serial.println(data[10]);
  Serial.print("data[12]:");
  Serial.println(data[12]);
  Serial.print("data[14]:");
  Serial.println(data[14]);
  */
  
  if (data[0] < 80 && data[2] < 80)
  {
    //0
    Serial.println("0");
  }
  else if (data[2] < 80 && data[4] < 80)
  {
    //30
    Serial.println("30");
  }
  else if (data[4] < 80 && data[6] < 80)
  {
    //60
    Serial.println("60");
  }
  else if (data[6] < 80 && data[8] < 80)
  {
    //90
    Serial.println("90");
  }
  else if (data[8] < 80 && data[10] < 80)
  {
    //120
    Serial.println("120");
  }
  else if (data[10] < 80 && data[12] < 80)
  {
    //150
    Serial.println("150");
  }
  else if (data[12] < 80 && data[14] < 80)
  {
    //180
    Serial.println("180");
  }

 if (millis() - lastmillis == 1000)
 {  /*Uptade every one second, this will be equal to reading frecuency (Hz).*/
     detachInterrupt(0);    //Disable interrupt when calculating
     rpm = rpmcount * 15;  // Convert frequency to RPM
 
     mph = ((rpm * 60 * PI * diameter)/5280);

     Serial.print("s");
     Serial.println(mph,DEC);
     //Serial.println(" mph");
     rpmcount = 0; // Restart the RPM counter
     lastmillis = millis(); // Uptade lasmillis
     attachInterrupt(0, rpm_fan, FALLING); //enable interrupt
  }
  
  
}

void updateSensor()
{
  Wire.requestFrom(9, 16);    // request 16 bytes from slave device #9
  while (Wire.available())   // slave may send less than requested
  {
    data[t] = Wire.read(); // receive a byte as character
    if (t < 15)
      t++;
    else
      t = 0;
  }
}


void initSensor()
{
  int floorQuality = 0;
  while (floorQuality < 6)
  {
    for(pos = 0; pos < 180; pos += 2)  // goes from 0 degrees to 180 degrees 
    {                                  // in steps of 1 degree
      updateSensor();
      if (data[0] > 195)
        floorQuality++;
      if (data[2] > 195)
        floorQuality++;
      if (data[4] > 195)
        floorQuality++;
      if (data[6] > 195)
        floorQuality++;
      if (data[8] >195)
        floorQuality++;
      if (data[10] > 195)
        floorQuality++;
      if (data[12] > 195)
        floorQuality++;
      if (data[14] > 195)
        floorQuality++;  
        
      if (floorQuality < 6)
      {
        myservo.write(pos);              // tell servo to go to position in variable 'pos' 
      }
      else
      {
        break;
      }
      delay(30);                       // waits 15ms for the servo to reach the position 
    } 
    for(pos = 180; pos>=1; pos-= 2)     // goes from 180 degrees to 0 degrees 
    { 
      updateSensor();
      if (data[0] > 195)
        floorQuality++;
      if (data[2] > 195)
        floorQuality++;
      if (data[4] > 195)
        floorQuality++;
      if (data[6] > 195)
        floorQuality++;
      if (data[8] >195)
        floorQuality++;
      if (data[10] > 195)
        floorQuality++;
      if (data[12] > 195)
        floorQuality++;
      if (data[14] > 195)
        floorQuality++;      
        
      if (floorQuality < 6)
      {
        myservo.write(pos);              // tell servo to go to position in variable 'pos' 
      }
      else
      {
        break;
      }
      delay(30);                       // waits 15ms for the servo to reach the position 
    } 
    //Serial.println("adjusting");
  }
  myservo.detach();
  //Serial.println("Floor detected. Starting...");
}

 /* this code will be executed every time the interrupt 0 (pin2) gets low.*/
void rpm_fan()
{
  rpmcount++;
}
