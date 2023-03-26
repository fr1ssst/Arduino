
#include <LCD_1602_RUS.h>

#define S1 5
#define S2 6
#define key 7

LCD_1602_RUS LCD(0x27, 16, 2);

int prevS1;
int curS1, curS2;

int val = 0;

bool flag = false;

int curKey;
unsigned long whenKeyPress = 0;

void setup() 
{
  LCD.init();
  LCD.backlight();

  pinMode (S1, INPUT);
  pinMode (S2, INPUT);
  pinMode (key, INPUT);

  prevS1 = digitalRead(S1); 
  Serial.begin (9600);
}

void loop() 
{
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
}

