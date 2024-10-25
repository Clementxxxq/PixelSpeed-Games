# Turbo Rivals
![image](https://github.com/Clementxxxq/Turbo-Rivals/blob/main/Image/1.jpg)
## Introduction
Turbo Rivals est un jeu de course dynamique où les joueurs affrontent des adversaires contrôlés par l'intelligence artificielle (IA) sur différents circuits. Les courses sont enrichies par un système d'objets spéciaux qui peuvent être utilisés stratégiquement pendant la course.

## Hiérarchie des Classes

### Class  A： TurboRivalsGame (Singleton)

| Attribut | Fonctions |
|-----:|---------------|
|circuits|setCircuits(),getCircuits()|
|currentRace|setCurrentRace(),getCurrentRace()|
|player|setPlayer(),getPlayer()|
|AIControllers|setAIControllers(),getAIControllers()|

| Méthodes |
|-----|
|startGame()|
|endGame()|
|loadRace()|


### Class  B： Vehicle (Abstract Factory Pattern)

| Attribut | Fonctions |
|-----:|---------------|
|speed|setSpeed(),getSpeed()|
|position|setPosition(),getPosition()|
|direction|setDirection(),getDirection()|
|boosts|setBoosts(),getBoosts()|

| Méthodes |
|-----|
|accelerate()|
|decelerate()|
|turnLeft()|
|turnRight()|
|useBoost()|


#### Class  B1： PlayerVehicle (Hérite de Vehicle)

| Méthodes |
|-----|
|controlVehicle()()|

#### Class  B2： AIVehicle  (Hérite de Vehicle)

| Méthodes |
|-----|
|navigateTrack()|


### Class  C： AIController

| Attribut | Fonctions |
|-----:|---------------|
|targetPosition|setTargetPosition(),getTargetPosition()|
|currentVehicle|setCurrentVehicle(),getCurrentVehicle()|

| Méthodes |
|-----|
|avoidObstacles()|
|calculateShortestPath()|


### Class  D： Item (Factory Pattern)

| Attribut | Fonctions |
|-----:|---------------|
|position|setPosition(),getPosition()|
|effect|setEffect(),getEffect()|

| Méthodes |
|-----|
|Activate()|

| Objets spéciaux  | Effet |
|-----:|---------------|
|Boost de Vitesse|Augmente la vitesse du véhicule|
|Bouclier défensif|Protection contre les attaques|
|Missile guide|Cibler et attaquer les véhicules|
|Tache d'huile|Ralentit les véhicules qui passent|
|EMP|Arrêt temporaire d'un véhicule non protégé|

### Class  E： Track


### Class  F： UIManager
| Attribut | Fonctions |
|-----:|---------------|
|scoreBoard|setScoreBoard(),getScoreBoard()|
|miniMap|setMiniMap(),getMiniMap()|
|roundNumber|setrRoundNumber(),getRoundNumberp()|
|miniMap|setMiniMap(),getMiniMap()|

