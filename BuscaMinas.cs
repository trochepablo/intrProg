function contarMinas(){
/* 
proposito: denota cantidad de minas que hay en las celdas alrededor de la actual.
orecondicion: -
*/
    cantidadMinas := 0;
    foreach dir in [minDir()..maxDir()]{
        cantidadMinas := contarMinasDiagonal(dir);
    }
    return (cantidadMinas);
}

function contarMinasDiagonal (dir){
/*
proposito: denota cantidad de bolitas que hay en las celdas alrededor de la actual
precondicion: -
*/
    Mover(dir);
    contarMinas := 0;
    contarMinas := acumularMinas(contarMinas)
    Mover(siguente(dir));
    contarMinas := acumularMinas(contarMinas)
    RetornarOrigen(opuesto(siguiente(dir), opuesto(dir)));
    return (contarminas)
}

function acumularMinas(cantidadMinas){
    acumuladorMinas := 0
    if (hayMina()){
        acumuladorMinas := cantidadMinas + nroBolitas(Rojo);
    }
    return (acumuladorMinas)
}

function hayMina(){
/*
porposito: detonar verdadero si hay una mina en la celda actual
precondicion: -
 */
    return (hayBolitas(Rojo))
}

procedure RetornarOrigen(dirHorizontal, dirVertical){
/*
proposito: mueve el cabezal hacia la celda origen
precondicion: el cabezal no debe estar en los extremos dirHorizontal y dirVertical
 */
    Mover(dirHorizontal);
    Mover(dirVertical);
}

//poner pista
procedure PonerPista(){
/*
proposito: pone en la celda actual una pista por cantidad de minas que hay en las celdas alrededor
precondicion: -
*/
    InicializarRecorrido(Norte, Este);
    while (puedoMoverHacia(Norte, Este))
    {
        ProcesarPista();
        IrAProximaCelda(Norte, Este);
    }

}

procedure ProcesarPista(){
    if(not hayMina()){
        ColocarPista();
    }
}

procedure ColocarPista(){
    repeat(contarMinas()){
        Poner(Azul)
    }
}

function puedoMoverHacia(dirPrin, dirSec){
    return (puedeMover(dirPrin) || puedeMover(dirSec))
}

procedure InicializarRecorrido(dirPrinc, dirSec){
    IrBorde(dirPrinc});
    IrBorde(dirSec});
}

procedure IrBorde(dir){
    while(puedeMover(dir)){
        Mover(dir);
    }
}

procedure IrAProximaCelda(dirPrinc, dirSec){
    if(puedeMover(dirPrin)){
        Mover(dirPrin);
    }
    else{
        Mover(dirSec)
        IrBorde(opuesto(dirSec));
    }
}
