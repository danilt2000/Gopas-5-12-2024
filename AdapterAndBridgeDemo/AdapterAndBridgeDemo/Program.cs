using AdapterAndBridgeDemo;

var calc = new CalcAdapter();
var calcClient = new CalcClient(calc);
calcClient.UseCalc();