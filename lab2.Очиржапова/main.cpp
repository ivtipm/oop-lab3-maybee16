#include "mainwindow.h"

#include <QApplication>
#include <QtWidgets/QLabel>
#include <QtWidgets/QSlider>
#include <QtWidgets/QVBoxLayout>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);

    QWidget w;
    QVBoxLayout *layoyt = new QVBoxLayout();

    QSlider *s = new QSlider(Qt::Horizontal);
    QLabel *l = new QLabel("0");

    layoyt->addWidget(s);
    layoyt->addWidget(l);
    w.setLayout(layoyt);

    QObject::connect(s, &QSlider::valueChanged, l, static_cast<void (QLabel::*)(int)>(&QLabel::setNum));

    w.show();
    return a.exec();
}
