#include <math.h>
#include <iostream>
using namespace std;

void trafo(float* s,int a);
void rueckTrafo(float* s,int r);


int main(void)
{
    int n;
    float *signal;
 cout <<"Gib die Laenge deines Stufensignals ein: ";
 cin >> n; 
 signal=new float[2*n];
 float z = log2(n);//Anzahl der Zerlegungsstufen.
 cout <<"Gib die Werte deines Stufensignals ein: " << "\n";
 for(int i=0; i<n; i++)
 { cin>> signal[i];
  //signal[i]= 255;
 //cout << signal[i]<<"\n";
 }
 if(z != int(z))//Hier wird das signal auf die länge 2^z gebracht durch auffüllen mit Nullen
     {
         z = 1 + z;
         z = int(z); 
         for(int i= n; i< pow(2,z); i++)
          {       signal[i] = signal[i-1];
                  cout << signal[i]<<"\n";
                  }
                  n = pow(2,z);
     }

//Transformation
for(int j=0; j< z; j++)// Durchläuft Anzahl der Zerlegungsstufen.
{       
        int h = int(pow(2,j));
        for(int i=0; i< h; i++)// Durchläuft alle Folgen pro Zerlegungstiefe und transformiert diese.
        {
                trafo(signal+(n*i)/h,n/h);
        }
}
cout << "\n" << "Transformiertes Signal: "<< "\n";
     for(int i=0; i<n; i++)
     { 
       cout<< signal[i] <<"\n"; 
       } 
//Rücktransformation:
int k = n;       
for(int j=0;j<z ; j++)// Durchläuft Anzahl der Zerlegungsstufen.
{       
        int h = int(pow(2,j));
        k = k/2;
        for(int i=0; i<k; i++)// Durchläuft alle Folgen pro Zerlegungstiefe und transformiert diese.
        {
                int p = (n*i)/k;
                rueckTrafo(signal+p,h);
        //cout<<"signal"<< signal[0]<< "\t" << signal[1]<<"\t" << signal[2]<<"\t" << signal[3] <<"\n";
        }
        
}
cout << "\n" << "Ruecktransformiertes Signal: "<< "\n";
     for(int i=0; i<n; i++)
     { 
       cout<< signal[i] <<"\n"; 
       }        
       
system ("Pause");
return 1;
}



void trafo(float* s,int a)// Transformation einer Folge
{    
  float c[a];
  for(int i=0; i<a/2; i++)
  {    
       c[i]= (s[2*i]+s[2*i+1])/sqrt(2);    
       c[i+(a/2)]= (s[i*2]- s[2*i+1])/sqrt(2);
  }
           
  for(int i=0; i<a; i++)
  {
       s[i] = c[i];
   }
}

 
void rueckTrafo(float* s,int r)// RückTransformation der auf eiener Zerlegungstufe 
{                            //zusammengehörigen Folgen
  float c[r];
  float e[r];
  for(int i=0; i<r; i++)
  {    //cout<<"übergabe" <<s[i] <<"\n";
       e[i]= (s[i]+s[i+r])/sqrt(2);    
       c[i]= (s[i]- s[i+r])/sqrt(2);
      // cout<< "e"<< e[i]<<"\t" << "c"<< c[i]<<"\n";
   }
   for(int j=0; j<r; j++)
  {     
      //cout<<"s"<< s[0-a]<< "\t" << s[1-a]<<"\t" << s[2-a]<<"\t" << s[3-a] <<"\n";
      s[2*j] = e[j];
      s[2*j+1] = c[j];
          //cout<<"s"<< s[0-a]<< "\t" << s[1-a]<<"\t" << s[2-a]<<"\t" << s[3-a] <<"\n";
          //cout<< j+a+1<< "\n"; 
       } 
}    



  
