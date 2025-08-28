# QuickNotes

## 📌 Idée du projet
Mini application en **.NET 8 Web API** pour gérer des **catégories** et des **notes**.  
Objectif : pratiquer Entity Framework Core (Code-First), SQLite et les migrations, puis publier le projet sur GitHub.

---

## 📂 Modèles
- **Category**
  - Id (clé primaire)
  - Name
  - Description
  - Notes (collection de notes liées)

- **Note**
  - Id (clé primaire)
  - Title
  - Content
  - Tags (optionnel)
  - CreatedAt
  - UpdatedAt
  - CategoryId (clé étrangère → Category.Id)

Relation : **1 catégorie → plusieurs notes**

---

## 🗄️ Base de données
- **SQLite** utilisée comme moteur de base légère.  
- La base est générée via **Entity Framework Core Code-First**.  
- Deux tables : `Categories` et `Notes`.

---

## 🔄 Migrations EF Core
Les migrations permettent de créer et mettre à jour la base depuis le code.  

### Commandes utilisées :
```bash
# Créer la première migration
dotnet ef migrations add Initial

# Appliquer la migration et créer la base (quicknotes.db)
dotnet ef database update
Packages utilisés

Microsoft.EntityFrameworkCore

Microsoft.EntityFrameworkCore.Sqlite

Microsoft.EntityFrameworkCore.Design

🖥️ Git & commandes

Projet versionné avec Git et poussé sur GitHub.

Commandes principales :
# Initialiser le repo
git init

# Ajouter tous les fichiers
git add .

# Créer un commit
git commit -m "Initial commit - QuickNotes API avec EF Core"

# Lier le repo local au repo GitHub
git remote add origin https://github.com/chanezAmokrane/QuickNotes.git

# Changer de branche pour main
git branch -M main

# Pousser sur GitHub
git push -u origin main
