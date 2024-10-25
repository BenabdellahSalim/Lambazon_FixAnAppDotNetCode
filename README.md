# DotNetprojet2
Spécifications fonctionnelles de l’application Lambazon L’application doit avoir les fonctionnalités suivantes. 
Ces informations sont un guide pour les tests et la documentation. 

  1. La page d’accueil doit permettre à l’utilisateur d’ajouter les articles dans son panier. 

  2. La page de présentation des produits doit afficher le nom, la description, le prix du produit et le nombre d’articles en stock. 

  3. Lorsque l’utilisateur clique sur « Ajouter au panier » : 
       1. Le produit est ajouté au panier avec une quantité de 1.
       2. L’utilisateur est ensuite redirigé vers la page de présentation du panier. 
       3. La page de présentation du panier affiche la quantité, le nom de l’article, le prix 
           unitaire et le prix total (quantité * prix de l’article). 
       4. Elle affiche également le total général des articles du panier. 
       5. Elle affiche le prix moyen des articles du panier. 


  4. Elle dispose d’un bouton, « Poursuivre les achats », qui redirige l’utilisateur vers la page de présentation des produits. 

  5. Elle dispose d’un bouton « Commander », qui redirige l’utilisateur vers la page de paiement. 

  6. Si l’utilisateur clique sur un produit qui est déjà dans son panier, ce dernier doit incrémenter la quantité de 1 et mettre à jour les totaux. 

  7. Pour toutes les pages, le menu déroulant de la langue est visible dans le pied de page. 
        1. L’utilisateur peut sélectionner Anglais, Français ou Espagnol. 
        2. Lorsque l’utilisateur clique sur « OK », le site passe à la langue choisie pour les éléments suivants : 
              1. Les intitulés de la page de présentation des produits. 
              2. Les intitulés de la page de présentation du panier. 
              3. Les intitulés de la page de paiement. 
              4. Tous les messages d’erreur. 
              5. Tous les intitulés des boutons. 
              6. Les options du menu déroulant de la langue. 

  8. La page de paiement. 
      1. Tous les champs doivent être remplis par l’utilisateur : nom, adresse, ville, code postal et pays.
      2. Afficher un message d’erreur si l’utilisateur ne remplit pas un champ obligatoire lorsqu’il clique sur « Terminer la commande ». 
      3. Une fois que l’utilisateur a terminé sa commande avec succès, voici les opérations à effectuer :
               1. La quantité de l’inventaire du produit (stock) diminue proportionnellement à la quantité indiquée dans la commande. 
               2. L’utilisateur est redirigé vers la page de présentation des produits.
               3. Mettre à jour la quantité en stock.
