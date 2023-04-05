1.ความเป็นมาของโปรแกรม
```
อยากสร้างโปรแกรมเกี่ยวกับการจองโรงแรม เพราะมีปัญหาเกี่ยวกับการที่คนเข้าพักเยอะ บริการไม่ทั่วถึง 
 ```
 2.วัตถุประสงค์ของโปรแกรม
```
1.เพื่อให้ผู้คนที่จะเข้ามาพักโรงแรมได้เลือกห้องที่ต้องการได้ง่ายขึ้น
2.สามารถมีอีเมลส่งไปบอกว่าลืมคีการ์ดเข้าห้องเพื่อให้เจ้าหน้าที่นำคีการ์ดสำรองมาให้
3.สามารถคำนวณตังค์ เเละมีส่วนลดให้ง่ายๆ เพื่อบางคนไม่ถนัด คณิต
```
3.โครงสร้างของโปรแกรม (Class diagram) ของโปรแกรม ใช้ Mermaid ในการเขียน ตัวอย่าง การเขียน Classdiagram ใน Markdown Class Diagram
```mermaid
classDiagram
 direction LR
 class Room{
 -cheakin():void
 -cheaout():void
 -Save():void
 -Clear():void
 -Pay():void
}
 class Pay{
 -pay():void
 -back():void
 -Print():void
 }
 class codepay{
 -couponCode:string
 -minimumPice:double
 +creat(double min):void
 +getCoupon():void
 }
 class Print{
 - Print_Load():void
 -Exit():void
  }
  Pay -- codepay
  Pay -- Print
  Room -- Pay
  ```
 4.ชื่อของผู้พัฒนาโปรแกรม
  ```
    นาย ธนาโชค สุวรรณ์ 653450287-7
  ```
