# 📖✨ Digital Diary 📖✨  
*A C# Console Application for CS 222 - Advanced Object-Oriented Programming*

---

## 📌 Project Description  

Welcome to **Digital Diary** — your personal console-based diary application where you can write, view, and search through your daily entries 📅💬. All your thoughts are securely stored in a text file (`diary.txt`) and managed through C#'s file handling tools like `StreamWriter`, `StreamReader`, and `File.Exists`.  

This app follows **object-oriented programming (OOP)** principles to maintain a modular, clean, and extendable code structure.

---

## 🌟 Features  

✅ Write a new diary entry 📓  
✅ View all your diary entries 📜  
✅ Search for a specific entry by date 🔍  
✅ Clear all entries securely 📛  
✅ Simple, intuitive console menu interface 🖥️  
✅ Text file-based storage using file handling classes 📁  

---

## 🛠️ How OOP Principles Are Used  

- **Encapsulation 🛡️**  
  - The file path and diary entry handling logic are hidden within the `Diary` class. External code only interacts through safe public methods.

- **Abstraction 🎭**  
  - The `Diary` class offers clear, simple-to-use public methods like `WriteEntry()`, `ViewAllEntries()`, and `SearchByDate()` — no need for the `Program` class to know how these work internally.

---

## 📂 File Structure  
> 📦 DigitalDiaryApp  
> ┣ 📜 Program.cs  
> ┣ 📜 Diary.cs  
> ┣ 📜 diary.txt (auto-created)  
> ┗ 📜 README.md



---
## 📷 Sample Output
```bash
=== DIGITAL DIARY ===
1. Write a New Entry
2. View All Entries
3. Search Entry by Date
4. Exit
Choose an option: 1

Write your diary entry (press Enter to submit): paul
Entry successfully written.

Press any key to return menu...

=== DIGITAL DIARY ===
1. Write a New Entry
2. View All Entries
3. Search Entry by Date
4. Exit
Choose an option: 2

---- All Entries ----
2025-05-06 22:41:45 | paul

Press any key to return menu...

=== DIGITAL DIARY ===
1. Write a New Entry
2. View All Entries
3. Search Entry by Date
4. Exit
Choose an option: 3

Enter date to search (YYYY-MM-DD): 2025-05-06
----- Entries on 2025-05-06 ----
2025-05-06 22:41:45 | paul

Press any key to return menu...

=== DIGITAL DIARY ===
1. Write a New Entry
2. View All Entries
3. Search Entry by Date
4. Exit
Choose an option: adfsd

Invalid option. Try again.
Press any key to return menu...

=== DIGITAL DIARY ===
1. Write a New Entry
2. View All Entries
3. Search Entry by Date
4. Exit
Choose an option: 4

Goodbye! See you again :)

```
---
## 👥 Team Members  

- 🧑‍💻 Alcaraz, Paul C. 
- 🧑‍💻 Guillermo, Gil Bryan O.  
- 🧑‍💻 Nayre, Christian B. 
- 👩‍💻 Rectin, Marielle J. 

---

## 🙏 Acknowledgement  

📚 Big thanks to our CS 222 - Advanced Object-Oriented Programming professor, Ms. Fatima Marie Agdon, for guiding us through the thrilling adventures of C# AOOP and file handling! 🚀 Your passion for teaching, sharp eye for detail, and endless patience truly made this journey not just educational—but enjoyable. Thank you for making complex concepts feel like an exciting puzzle, and for always cheering us on, one bracket at a time! 💻✨

---

> ✨ *“A diary is the voice of your heart you can always return to.”* ✨  
