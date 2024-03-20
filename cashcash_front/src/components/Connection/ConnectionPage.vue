<template>
    <div class="connectionPage">

        <div class="titleContainer">
            <img class="logo" src="../../assets/logo.png" />
        </div>
        <div class="formsContainer">
            <div class="block">
                <div class="ml-3">
                    <div class="inputs">
                        <p class="label">Mail</p>
                        <input v-model="mail" type="text" />
                        <p  class="label">Mot de passe</p>
                        <input v-model="password" type="password" /><br />
                        <button @click="Authentification" class="connectButton">Connexion</button><br /><br />
                        <a class="link" @click="openSignUp = !openSignUp">Mot de passe oublié</a>
                    </div>
                </div>
            </div>
        </div>

    </div>
</template>


<script lang="js">
import { defineComponent } from 'vue';

export default defineComponent({
    data() {
        return {
            name: '',
            lastName: '',
            mail: '',
            password: '',
            signupPassword: '',
            signupMail: '',
            openSignUp: false
        };
    },
    methods: {
        Authentification() {
            const requestOptions = {
                method: "POST",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify({
                    Mail: this.mail,
                    Password: this.password,
                })
            };
            fetch(`${this.$api}/Users/Authentification`, requestOptions)
                .then(response => {
                    if (response.ok) {
                        localStorage.setItem('isConnected', true)
                        return response.json()
                    }
                    else { alert("Erreur. L'identifiant ou le mot de passe est incorrect.") }
                })
                .then(data => {
                    // localStorage.setItem('userMail', data.Mail)
                    // localStorage.setItem('userId', data.id)
                    location.reload()
                })
        },
    }
}
);
</script>

<style scoped>
.ml-3 {
    margin-left: 5%;
}

.connectionPage {
    position:fixed;
    padding:0;
    margin:0;

    top:0;
    left:0;

    width: 100%;
    height: 100%;
    background:#103941;

}

body {
    position: fixed;
    padding: 0;
    margin: 0;

    top: 0;
    left: 0;

    width: 100%;
    height: 100%;
    background: rgba(255, 255, 255, 0.5);
}

.formsContainer {
    display: flex;
    justify-content: space-around;
    padding-top: 3%;
    margin-left: 5%;
    margin-right: 5%;
}

.label {
    font-size: 21px;
}

.block {
    height: 65vh;
    width: 40%;
    vertical-align: middle;
    background-color: transparent;
    border-radius: 10px;
    border: solid 3px #103941;
}

.titleContainer {
    display: flex;
    justify-content: center;
    margin-top: 5%;
}

.logo {
    height: 180px;
    vertical-align: middle;
}

.title {
    color: #103941;
}

.inputs {
    display: block;
}

p {
    color: #fff;
}

.link {
    cursor: pointer;
    transition: .4s ease-in-out;
}

.link:hover {
    color: aqua;
}

input {
    border: solid 2px #fff;
    background-color: #f3f3f3 !important;
    border-radius: 5px;
    background-color: transparent;
    height: 40px;
    width: 50%;
    color: black;
    font-size: 18px;
}

.connectButton {
    margin-top: 5%;
    padding: 1.5% 5%;
    border-radius: 5px;
    border: solid 2px white;
    background-color: transparent;
    color: white;
    font-size: 18px;
    transition: .3s ease-in-out;
}

.connectButton:hover {
    background-color: #fff;
    color: black;
    border-color: #fff;
}

@media screen and (max-width: 900px) {
    .formsContainer {
        display: block;
    }

    .block {
        width: 100%;
    }
}
</style>