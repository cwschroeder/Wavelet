#include<QtGui>
#include "Programm.h"
#include "Bild.h"
Programm::Programm()
{ 
image=new QImage(Programm::fileName);
	QMenu *Menu;    
	QAction *quitAct,*einlesen,*abspeichern, *abspeichernalles, *pixellesen, *lesenpixellesen;
    Hintergrund = new Bild();

	quitAct=new QAction("Beenden",0);
	quitAct->setShortcut(QKeySequence("Ctrl+Q"));
	
	einlesen=new QAction("Bild einlesen",0);
	einlesen->setShortcut(QKeySequence("Ctrl+L"));

	pixellesen=new QAction("aktuelles Bild->Pixel",0);
	pixellesen->setShortcut(QKeySequence("Ctrl+P"));
	
	lesenpixellesen=new QAction("Bild einlesen->Pixel",0);
	lesenpixellesen->setShortcut(QKeySequence("Ctrl+P"));
    	
	abspeichern=new QAction("Pixel->Bild schwarz/weiß",0);
	abspeichern->setShortcut(QKeySequence("Ctrl+F"));

	abspeichernalles=new QAction("Pixel->Bild",0);
	abspeichernalles->setShortcut(QKeySequence("Ctrl+S"));
           	
    QDate date=QDate::currentDate();  
    QLabel *datum=new QLabel(date.toString("dd.MM.yyyy"));
    QString copy=QChar(169);
    QLabel *copyright=new QLabel(copy+" Tobias Schubert");
//    QStatusBar *statusBar;
    statusBar()->addWidget(datum);
    statusBar()->addWidget(copyright);

	setStatusBar(statusBar());
	
	Menu=menuBar()->addMenu("&Datei");
	Menu->addAction(quitAct);
	quitAct->setStatusTip("beenden");
	Menu=menuBar()->addMenu("&Laden/Speichern");
	Menu->addAction(einlesen);
	Menu->addAction(pixellesen);
	Menu->addAction(lesenpixellesen);        	
	Menu->addAction(abspeichern);
//	Menu->addAction(abspeichernalles);	
//	QToolBar *tb;
//	tb=addToolBar("Datei");
//	tb->addAction(quitAct);
//	tb=addToolBar("Bild");
//	tb->addAction(einlesen);
//	tb->addAction(abspeichern);	
 	setCentralWidget(Hintergrund);            
    connect(quitAct,SIGNAL(triggered()),qApp,SLOT(quit()));
    connect(einlesen,SIGNAL(triggered()),this,SLOT(laden()));
    connect(pixellesen,SIGNAL(triggered()),this,SLOT(toPixel()));
    connect(lesenpixellesen,SIGNAL(triggered()),this,SLOT(ladentoPixel()));        
    connect(abspeichern,SIGNAL(triggered()),this,SLOT(toImage()));
}
void Programm::ladentoPixel()
{
     this->laden();
     this->toPixel();
}
bool Programm::laden()
{
Programm::fileName = QFileDialog::getOpenFileName(this, tr("Open File"),
                                                 "./Bild/",
                                                 tr("Images (*.png *.bmp *.jpg)")); 

QMessageBox Fehlt;
if(Programm::fileName=="")
return 1;


Hintergrund->image->load(Programm::fileName);
Hintergrund->update();
return 0;
}
void Programm::toPixel()
{ 
QImage Bild(Programm::fileName);
QSize Size;
QColor c;
QString str="";
Size=Bild.size(); 
QMessageBox Fehlt;
if(Size.height()>0&&Size.width()>0)
{
//Fehlt.critical(this,"Achtung",QString::number(Size.height())+" "+QString::number(Size.width()));
int**Blau, **Rot,**Grun,**Black;


Blau=new int*[Size.height()];
for(int i=0;i<Size.height();i++)    
{
Blau[i]=new int[Size.width()];
}
//Fehlt.critical(this,"Achtung",QString::number(Size.width())+" "+QString::number(Size.height()));
for(int i=0;i<Size.height();i++)    
{
for(int j=0;j<Size.width();j++)    
{
Blau[i][j]=c.fromRgb(Bild.pixel(j,i)).blue();    
// A[i][j]=Bild.pixel(i,j); 
//Fehlt.critical(this,"Achtung","i "+QString::number(i)+"j "+QString::number(j)+" "+QString::number(Blau[i][j]));   
}
}

Grun=new int*[Size.height()];
for(int i=0;i<Size.height();i++)    
{
Grun[i]=new int[Size.width()];
}
//Fehlt.critical(this,"Achtung",QString::number(Size.width())+" "+QString::number(Size.height()));
for(int i=0;i<Size.height();i++)    
{
for(int j=0;j<Size.width();j++)    
{
Grun[i][j]=c.fromRgb(Bild.pixel(j,i)).green();    
// A[i][j]=Bild.pixel(i,j); 
//Fehlt.critical(this,"Achtung","i "+QString::number(i)+"j "+QString::number(j)+" "+QString::number(Blau[i][j]));   
}
}
Rot=new int*[Size.height()];
for(int i=0;i<Size.height();i++)    
{
Rot[i]=new int[Size.width()];
}
//Fehlt.critical(this,"Achtung",QString::number(Size.width())+" "+QString::number(Size.height()));
for(int i=0;i<Size.height();i++)    
{
for(int j=0;j<Size.width();j++)    
{
Rot[i][j]=c.fromRgb(Bild.pixel(j,i)).red();    
// A[i][j]=Bild.pixel(i,j); 
//Fehlt.critical(this,"Achtung","i "+QString::number(i)+"j "+QString::number(j)+" "+QString::number(Blau[i][j]));   
}
}

Black=new int*[Size.height()];
for(int i=0;i<Size.height();i++)    
{
Black[i]=new int[Size.width()];
}
//Fehlt.critical(this,"Achtung",QString::number(Size.width())+" "+QString::number(Size.height()));
for(int i=0;i<Size.height();i++)    
{
for(int j=0;j<Size.width();j++)    
{
Black[i][j]=255-c.fromRgb(Bild.pixel(j,i)).black();    
// A[i][j]=Bild.pixel(i,j); 
//Fehlt.critical(this,"Achtung","i "+QString::number(i)+"j "+QString::number(j)+" "+QString::number(Blau[i][j]));   
}
}

//Fehlt.critical(this,"Achtung","i hier");
//for(int i=0;i<Size.height();i++)    
//{
//for(int j=0;j<Size.width();j++)    
//{
//  str=str+QString::number(Blau[i][j])+" ";     
//}
//str=str+"\n";
//}
//Fehlt.critical(this,"Achtung",str);
QString strFile;
QStringList list = Programm::fileName.split("/");
strFile="./Bild/"+list[list.size()-1].split(".")[0];


//Fehlt.critical(this,"Achtung",strFile);

QFile file(strFile+"_blue.txt");
file.open(QIODevice::WriteOnly);
QTextStream out(&file);
for(int i=0;i<Size.height();i++)    
{
for(int j=0;j<Size.width();j++) 
{
if(j<Size.width()-1)
out<<QString::number(Blau[i][j])<<"\t";
else 
out<<QString::number(Blau[i][j])<<"\n";
}
}
file.close();
//Fehlt.critical(this,"Achtung","blau");

QFile file2(strFile+"_red.txt");
file2.open(QIODevice::WriteOnly);
QTextStream out2(&file2);
for(int i=0;i<Size.height();i++)    
{
for(int j=0;j<Size.width();j++) 
{
if(j<Size.width()-1)
out2<<QString::number(Rot[i][j])<<"\t";
else 
out2<<QString::number(Rot[i][j])<<"\n";
}
}
file2.close();

QFile file3(strFile+"_green.txt");
file3.open(QIODevice::WriteOnly);
QTextStream out3(&file3);
for(int i=0;i<Size.height();i++)    
{
for(int j=0;j<Size.width();j++) 
{
if(j<Size.width()-1)
out3<<QString::number(Grun[i][j])<<"\t";
else 
out3<<QString::number(Grun[i][j])<<"\n";
}
}
file3.close();

QFile file4(strFile+"_black.txt");
file4.open(QIODevice::WriteOnly);
QTextStream out4(&file4);
for(int i=0;i<Size.height();i++)    
{
for(int j=0;j<Size.width();j++) 
{
if(j<Size.width()-1)
out4<<QString::number(Black[i][j])<<"\t";
else 
out4<<QString::number(Black[i][j])<<"\n";
}
}
file4.close();
QMessageBox fehlt;
fehlt.information(this,"Ok","Pixel wurden in "+strFile+"_black.txt abgespeichert!");
}

}
bool Programm::toImage()
{ 
Programm::txtfileName = QFileDialog::getOpenFileName(this, tr("Open File"),
                                                 "./Bild/",
                                                 tr("Text files (*.txt)"));  
if(Programm::txtfileName=="")
return 1;
QString strFile;
QStringList listFile = Programm::txtfileName.split("/");
QString speicher=listFile[listFile.size()-1].split(".")[0];
strFile="./Bild/"+speicher+"_neu.bmp";
QString Farbe=speicher.split("_")[1];
QStringList list;

QMessageBox Fehlt;
int Spaltenlaenge=0,Zeilenlaenge=0;
//Fehlt.critical(this,"Achtung","hier1"+Farbe);

QFile file(Programm::txtfileName);
if (!file.open(QIODevice::ReadOnly))
{

Fehlt.critical(this,"Achtung",Programm::txtfileName+" konnte nicht gefunden werden!");

}
else
{
QTextStream out(&file);

//Fehlt.critical(this,"Achtung","hier2"+Programm::txtfileName);
if(out.atEnd()==0)
{
list=out.readLine().split(QRegExp("\\s+"),QString::SkipEmptyParts); 
Spaltenlaenge=list.size();
//Fehlt.critical(this,"Achtung","list"+QString::number(Spaltenlaenge));                
}
list=list+out.readAll().simplified().split(QRegExp("\\s+"),QString::SkipEmptyParts);
file.close();
//Fehlt.critical(this,"Achtung","hier3");
if(Spaltenlaenge==0)
{
Fehlt.critical(this,"Achtung",Programm::txtfileName+" ist leer!");                    
}
else
{
Zeilenlaenge=list.size()/Spaltenlaenge;
QSize Size(Spaltenlaenge,Zeilenlaenge);

QImage bild(Size,QImage::Format_RGB32);
//bild.save(strFile+"x", "BMP");
        bild.setPixel(0,0,30); 
QColor monochrom;
// Fehlt.critical(this,"Achtung","x"+Farbe+" "+QString::number(list.size())); 
               
for(int i=0;i<list.size();i++)
{
monochrom.setBlue(list[i].toInt());
monochrom.setRed(list[i].toInt());
monochrom.setGreen(list[i].toInt());
        bild.setPixel(i%Spaltenlaenge,i/Spaltenlaenge,monochrom.rgb()); 
}

//Fehlt.critical(this,"Achtung",list[10]+" "+QString::number(list[10].toUInt())+" "+QString::number(qBlue(bild.pixel(10,0))));
//bild.save(strFile, "BMP");

bild.save(strFile,0,100);
QMessageBox fehlt;
fehlt.information(this,"","Bild wurde in "+strFile+" abgespeichert!");
}

}

return 0;
}
