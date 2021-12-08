int val;  
void setup() 
{ 
  Serial.begin(9600);
  pinMode(13,OUTPUT);
} 
 
void loop() 
{ 
  if(Serial.available()>0){
    val = Serial.read();
    if(val==1){
     digitalWrite(13,HIGH);
    }else{
      digitalWrite(13,LOW);
    }  
}

  //will be rearranged
