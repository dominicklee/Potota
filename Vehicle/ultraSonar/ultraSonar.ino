/* Pinouts - The #s are the pinouts for each sensors.
 *  
 * Sensor 1 
 * Trig - 4
 * Echo - 8
 * 
 * Sensor 2
 * Trig - 5
 * Echo - 9
 * 
 * Sensor 3
 * Trig - 6
 * Echo - 10
 * 
 * Sensor 4
 * Trig - 7
 * Echo - 11
 */

#define Echo1 8
#define Trig1 4

#define Echo2 9
#define Trig2 5

#define Echo3 10
#define Trig3 6

#define Echo4 11
#define Trig4 7

void sense(uint8_t, uint8_t, uint8_t);
void initPorts();

void setup()
{
  Serial.begin (9600);
  initPorts();
  pinMode(12, OUTPUT);    //pulled high when rear mode
}

void loop()
{
  sense(Echo1, Trig1, 1);
  Serial.print(",");
  sense(Echo2, Trig2, 2);
  Serial.print(",");
  sense(Echo3, Trig3, 3);
  Serial.print(",");
  sense(Echo4, Trig4, 4);
  
  Serial.println("");
  
}

void sense(uint8_t Echo, uint8_t Trig, uint8_t num)
{
  pinMode(12, OUTPUT);  //buzzer
  uint16_t duration = 0, distance = 0;
  
  digitalWrite(Trig, LOW);
  delayMicroseconds(2);
  digitalWrite(Trig, HIGH);

  delayMicroseconds(10);
  digitalWrite(Trig, LOW);

  duration = pulseIn(Echo, HIGH);
  
  distance = ((duration/2.00) / 29.10);
  distance = distance/2.54;  //converts cm to inches
  
  if(distance >= 78.74 || distance <= 0)
  {
    /*
    Serial.print("Sensor #");
    Serial.print(num);
    Serial.print(" out of range");
    */
    Serial.print("-1");
    digitalWrite(12, LOW);
  }
  else
  {
    Serial.print(distance);

        if (distance < 10)
        {
          digitalWrite(12, HIGH);
        }
        else
        {
   digitalWrite(12, LOW);
        }
  
    /*
    Serial.print("Sensor #");
    Serial.print(num);
    Serial.print(": ");
    Serial.print(distance);
    Serial.print(" ");
    */
  }
}

void initPorts()
{
  pinMode(Trig1, OUTPUT);
  pinMode(Trig2, OUTPUT);
  pinMode(Trig3, OUTPUT);
  pinMode(Trig4, OUTPUT);
  
  pinMode(Echo1, INPUT);
  pinMode(Echo2, INPUT);
  pinMode(Echo3, INPUT);
  pinMode(Echo4, INPUT);
}
