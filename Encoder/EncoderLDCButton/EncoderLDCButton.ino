
#include <LCD_1602_RUS.h>

#define S1 5
#define S2 6
#define key 7

LCD_1602_RUS LCD(0x27, 16, 2);

int prevS1;
int curS1, curS2;

int blueButton = 4;
int redButton = 3;
int yellowButton = 2;

int echoPin = 9;
int trigPin = 8;

int ledPin = 13;

int val = 0;

bool flag = false;

int curKey;
unsigned long whenKeyPress = 0;

void setup() 
{
  LCD.init();
  LCD.backlight();

  pinMode(blueButton, INPUT);
  pinMode(redButton, INPUT);
  pinMode(yellowButton, INPUT);

  pinMode(echoPin, INPUT);
  pinMode(trigPin, OUTPUT);

  pinMode(ledPin, OUTPUT);

  pinMode (S1, INPUT);
  pinMode (S2, INPUT);
  pinMode (key, INPUT);

  prevS1 = digitalRead(S1); 
  Serial.begin (9600);
}

void loop() 
{
  int duration, cm;

  curS1 = digitalRead(S1);

  
  if (curS1 != prevS1)
  {
    curS2 = digitalRead(S2);
    if (flag)
    {
        if (curS2==curS1)
         {
            val++;
         }
         else 
         {
            val--;
         }
         LCD.clear();
         LCD.setCursor(5,0);
         LCD.print("Value");
         LCD.setCursor(5,1);
         LCD.print(val);

         //Serial.print ("Value = "); //print text in console
         //Serial.println (val); //print val in console
         flag=false;
    }
    else 
    {
      flag=true;
    }

  }
  prevS1=curS1;

  int curKey = digitalRead(key);
  if (curKey == LOW)
   {
    if (millis() - whenKeyPress > 50) 
    {
         LCD.clear();
         LCD.setCursor(5,0);
         LCD.print("Click");   
    }
    
    whenKeyPress = millis();
  }

   //Blue button
    if(digitalRead(blueButton) == HIGH) 
    {
         digitalWrite(ledPin, HIGH);
         LCD.clear();
         LCD.setCursor(4,0);
         LCD.print("Blue button");  
    }
    else 
    {
      digitalWrite(ledPin, LOW);
    }
    //Red button
    if(digitalRead(redButton) == HIGH)
    {
         digitalWrite(ledPin, HIGH);
         LCD.clear();
         LCD.setCursor(4,0);
         LCD.print("Red button");  
    }
    else 
    {
      digitalWrite(ledPin, LOW);
    }
    //Yellow button
    if(digitalRead(yellowButton) == HIGH)
    {
         digitalWrite(ledPin, HIGH);
         LCD.clear();
         LCD.setCursor(4,0);
         LCD.print("Yellow button");  
    }
    else 
    {
      digitalWrite(ledPin, LOW);
    }
    
}

