namespace games.models {
     
     public class BoardGame {

        public string? name {get; set;}

        public string? GetName() {
            return this.name;
        }

        public void SetName(string? name) {
            this.name = name;
        }

        public int maxPlayers {get; set;}
        public int minPlayers {get; set;}
        public int avgPT {get; set;}
        public int difficulty {get; set;}
        public bool expansion {get; set;}
        public int maybeMinPlayers() {
            if (this.expansion == true) {
                return (this.minPlayers + 2);
            }
            else {
                return this.minPlayers;
            };
        }
        public int maybeMaxPlayers() {
            if (this.expansion == true) {
                return (this.maxPlayers + 2);
            }
            else {
                return this.maxPlayers;
            };
        }

        public BoardGame(string name, bool expansion, int minPlayers, int maxPlayers, int avgPT, int difficulty) {
            this.name = name;
            this.expansion = expansion;
            this.minPlayers = minPlayers;
            this.maxPlayers = maxPlayers;
            this.avgPT = avgPT;
            this.difficulty = difficulty;
        }
     }

     public class VideoGame {
        public string? name {get; set;}
        public string? GetName() {
            return this.name;
        }

        public void SetName(string? name) {
            this.name = name;
        }

        public bool singlePlayerOrNah {get; set;}
        public bool onlineOrNah {get; set;}
        public int difficulty {get; set;}
        public string players() {
            if (this.singlePlayerOrNah == true) {
                return "one";
            }
            else {
                return "multiple";
            }
        }
        public string mode() {
            if (this.onlineOrNah == true) {
                return "online or locally";
            }
            else {
                return "local only";
            }
        }

        public VideoGame (string name, bool singlePlayerOrNah, bool onlineOrNah, int difficulty) {
            this.name = name;
            this.singlePlayerOrNah = singlePlayerOrNah;
            this.onlineOrNah = onlineOrNah;
            this.difficulty = difficulty;
        }
    }
}