
Keyboard keyboard = new Keyboard();

// 
keyboard.PressKeyA += new PressKeyEventHandler(PressKeyA_Handler);
keyboard.PressKeyB += PressKeyB_Handler;

// 
keyboard.Start();
