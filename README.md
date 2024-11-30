# **Lambazon - Gestion des Produits et des Stocks**

## **Description du projet**

Lambazon est une application web conçue pour la gestion des stocks et des commandes. Elle permet aux utilisateurs de parcourir un catalogue de produits, de gérer leur panier, et d'effectuer des commandes tout en offrant une interface interne pour la gestion des stocks. Cette application est multi-langues, avec un support pour le français, l'anglais, et l'espagnol.

## **Spécifications fonctionnelles**

### **Fonctionnalités principales**
1. **Page d’accueil :**
   - Ajouter des articles au panier.

2. **Page de présentation des produits :**
   - Afficher le nom, la description, le prix et le nombre d’articles en stock.
   - Ajouter un produit au panier avec une quantité initiale de 1.
   - Rediriger l’utilisateur vers la page de présentation du panier.

3. **Page de présentation du panier :**
   - Afficher la quantité, le nom, le prix unitaire et le prix total des articles.
   - Calculer le total général et le prix moyen des articles.
   - Inclure des boutons :
     - **Poursuivre les achats** : Retour à la page des produits.
     - **Commander** : Rediriger vers la page de paiement.

4. **Page de paiement :**
   - Champs obligatoires : nom, adresse, ville, code postal, et pays.
   - Validation des champs et messages d’erreur en cas d’omission.
   - Mise à jour du stock après commande.

5. **Gestion des langues :**
   - Sélection entre Anglais, Français et Espagnol.
   - Traduction dynamique des pages, des messages d’erreur, et des boutons.

### **Fonctionnalités internes ajoutées**
- Interface interne pour **créer** et **valider des produits** avant leur enregistrement dans le système.
- Suivi et mise à jour des stocks via une interface intuitive pour les équipes internes.

---

## **Ajouts récents**

- **Validation des produits** : Une étape a été ajoutée pour approuver les nouveaux produits avant leur enregistrement.
- **Tests unitaires et d’intégration** : 
  - Tests unitaires pour valider la logique métier.
  - Tests d’intégration pour garantir une bonne interaction entre les composants de l’application.
  - Base de données In-Memory utilisée pour les tests.

---

## **Technologies utilisées**

- **ASP.NET Core** pour le développement backend.
- **Entity Framework Core** pour la gestion des données.
- **In-Memory Database** pour les tests.
- **XUnit** pour les tests unitaires et d’intégration.
- **IStringLocalizer** pour la gestion des langues.

---


