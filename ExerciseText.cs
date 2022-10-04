using System.Runtime.ConstrainedExecution;

//Per l’esercitazione di oggi la repo sarà: la - mia - pizzeria - model
//IMPORTANTE: Per svolgere questo esercizio e tutti quelli che seguiranno dovrete partire dal vostro progetto nel punto in cui lo avevate lasciato, ma dovete sganciare la vecchia repository git, eliminando la cartella git e tutti i file di git associati. Una volta fatto se voi aprite la vostra soluzione noterete che git non è più configurato e potrete dunque ricreare una nuova repository a partire da dove avevate lasciato il vostro progetto precedente.

//Oppure
//Potete creare un nuovo progetto e copiare i file di codice e i file statici che avete modificato.

//Lo scopo di oggi è quello di rendere dinamici i contenuti che abbiamo come html statico nella pagina con la lista delle pizze.
//Creiamo prima un nostro controller chiamato PizzaController e utilizziamo lui d’ora in avanti.

//L’elenco delle pizze ora va passato come model dal controller, e la view deve utilizzarlo per mostrare l’html corretto.
//Gestiamo anche la possibilità che non ci siano pizze nell’elenco: in quel caso dobbiamo mostrare un messaggio che indichi all’utente che non ci sono pizze presenti nella nostra applicazione.

//Ogni pizza dell’elenco avrà un pulsante che se cliccato ci porterà a una pagina che mostrerà i dettagli di quella singola pizza. Dobbiamo quindi inviare l’id come parametro dell’URL, recuperarlo con la action, caricare i dati della pizza ricercata e passarli come model. La view a quel punto li mostrerà all’utente con la grafica che preferiamo.

//Ps. visto che abbiamo cambiato il controller sul quale lavoriamo, ricordiamoci di cambiare anche il “mapping di default” dei controller...altrimenti quale pagina viene caricata se richiamo l’url “/” della nostra webapp?