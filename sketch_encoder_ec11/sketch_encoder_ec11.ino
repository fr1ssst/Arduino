
#define S1 5
#define S2 6
#define key 7


int prevS1;
int curS1, curS2;

int val = 0;

bool flag=false;

int curKey;
unsigned long whenKeyPress = 0;

void setup() {
  // put your setup code here, to run once:
  
  pinMode (S1, INPUT);
  pinMode (S2, INPUT);
  pinMode (key, INPUT);
  prevS1 = digitalRead(S1); 
  Serial.begin (9600);
}

void loop() {
  // put your main code here, to run repeatedly:

  curS1 = digitalRead(S1);
  
  if (curS1!=prevS1){
    curS2 = digitalRead(S2);
    if (flag){
        if (curS2==curS1){
            val++;
         }
         else {
            val--;
         }
         Serial.print ("Value = ");
         Serial.println (val);
         flag=false;
    }
    else {
      flag=true;
    }

  }
  prevS1=curS1;

  int curKey = digitalRead(key);
  if (curKey == LOW) {
    if (millis() - whenKeyPress > 50) {
      Serial.println("Key down");
    
    }
    
    whenKeyPress = millis();
  }
}
