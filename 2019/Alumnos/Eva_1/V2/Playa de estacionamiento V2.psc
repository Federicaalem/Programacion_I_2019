Proceso PlayaDeEstacionamiento
	Definir  hora como entero;
	Definir cobro como entero;
	Definir opc como entero;
	//Variables
	hora <- 0;
	cobro <- 0;
	
	Repetir
		Escribir " ������������������������";
		Escribir " 1) Ingreso de autos.";
		Escribir " 2) Salir.";
		Escribir " ������������������������";
		Leer opc;
		Limpiar Pantalla;
		
		Segun opc Hacer
			1:
				Escribir " ������������������������";
				Escribir "Ingrese Horas";
			2:
				Escribir " ������������������������";
				Escribir "Saliendo...";
			De Otro Modo:
				Escribir " ������������������������";
				Escribir "ERROR";
		FinSegun
		Leer hora;
		Limpiar Pantalla;
		
		
		Si hora >0 Y hora <=2 Entonces
			Escribir " ������������������������";
			Escribir "Total de horas: ", hora;
			cobro<- hora*65;
			Escribir "Total a cobrar: : " ,cobro, " Pesos";
			Escribir "Total a cobrar: " ,cobro, " Pesos";
			Escribir " ������������������������";
			Escribir "Presione cualquier tecla para continuar";
			Esperar tecla;
			Limpiar Pantalla;
		FinSi
		Limpiar Pantalla;
		Si  hora>2 y hora<=5  Entonces
			
			Escribir  "Total de horas: ", hora,;
			cobro <- hora*65;
			Escribir "Total a cobrar: " ,cobro, "Pesos";
			Escribir "Total a cobrar: " ,cobro, " Pesos";
			Escribir " ������������������������";
			Escribir "Presione cualquier tecla para continuar";
			Esperar tecla;
			Limpiar Pantalla;
		FinSi
		
		Si hora>5 Y hora<=10 Entonces
			
			Escribir "Total de horas: ", hora;
			cobro <- hora*65;
			Escribir "Total a cobrar: " ,cobro," Pesos";
			Escribir "Total a cobrar: " ,cobro, " Pesos";
			Escribir " ������������������������";
			Escribir "Presione cualquier tecla para continuar";
			Esperar tecla;
			Limpiar Pantalla;
		FinSi
		
		Si hora>10 Entonces
			
			Escribir "Total de horas: ", hora;
			cobro <- hora*65;
			Escribir "Total a cobrar: " ,cobro, " Pesos";
			Escribir " ������������������������";
			Escribir "Presione cualquier tecla para continuar";
			Esperar tecla;
			Limpiar Pantalla;
		FinSi
	Hasta Que opc = 2;

	
	
	
	
	
	
	
FinProceso
