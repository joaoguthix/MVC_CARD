<template>
    <body>
        <form>
            <fieldset>
                <div>
                    <label>Digite o Nome Impresso no Cartão</label>
                    <input type="text" v-model="nome">
                </div>
            </fieldset>  
            <fieldset>
                <div>
                    <label>Digite o Numero Impresso no Cartão</label>
                    <input type="text" v-model="numero" v-bind:on-click="back">
                </div>
            </fieldset>  
        </form>

        <div class="card">
            <div class="container">
                <div class="header">
                    <div class="box-img">
                        <img src="../assets/Image/mastercard_logo.png" alt="mastercard">
                        <img src="../assets/Image/chip.png" alt="chip">
                    </div>
                </div>
                <div class="footer">
                    <p>{{ nome }}</p>
                    <img src="../assets/Image/nubank_logo.png" alt="nubank">
                </div>
            </div>

            <div class="container">
                <div class="header">
                    <div class="box-img">
                    </div>
                </div>
                <div class="footer-back">
                    <p>{{ numero }}</p>
                    <ul> cvc </ul>
                </div>
            </div>
        </div>
        
    </body>
</template>


<script>
export default {
    data(){
        return{
            nome: '',
            numero: '',
        }
    }
}
    
    
</script>

<style scoped> 

body{
    background-color: #000;
    height:100vh
}
form{
    background-color: #000;
    display: flex;
    font-family: Arial, Helvetica;
    color: #fff;
    height: 70px;
    width: 250px;
}

@media (min-width: 200px){
.card{
    display: flex;
    font-family: Arial, Helvetica;
    color: #fff;
    height: 170px;
    width: 250px;
    display: table; 
    margin: 8% auto; 

}
.container{
    background-color: #820ad1;
    padding: 1em;
    border-radius: 4%;
    width: 100%;
    height: 100%;
    box-shadow: #000;
}

.header{
    height: 55%;
}
.box-img{
    display: flex;
    align-items: flex-start;
}

.footer img{
    width: 35%;
}

.footer p{
    font-size: 15px;
    padding-left: 1em;
}
.footer-back p{
    font-size: 15px;
    padding-left: 1em;
}

img[alt=mastercard]{
    width: 20%;
}
img[alt=chip]{
    width: 30%;
    
}
img[alt=nubank]{
    width: 20%;
}
}

@media (min-width: 412px){

    .card{
    display: flex;
    font-family: Arial, Helvetica;
    color: #fff;
    height: 200px;
    width: 300px;
    display: table; 
    margin: 8% auto; 

}
.container{
    background-color: #820ad1;
    padding: 1em;
    border-radius: 4%;
    width: 100%;
    height: 100%;
    box-shadow: #000;
}

.header{
    height: 55%;
}
.box-img{
    display: flex;
    align-items: flex-start;
}

.footer img{
    width: 35%;
}

.footer p{
    font-size: 20px;
    padding-left: 1em;
}

img[alt=mastercard]{
    width: 25%;
}
img[alt=chip]{
    width: 35%;
    
}
img[alt=nubank]{
    width: 25%;
}
}

@media (min-width: 540px){

.card{
display: flex;
font-family: Arial, Helvetica;
color: #fff;
height: 230px;
width: 380px;
display: table; 
margin: 8% auto; 

}
.container{
background-color: #820ad1;
padding: 1em;
border-radius: 4%;
width: 100%;
height: 100%;
box-shadow: #000;
}

.header{
height: 60%;
}
.box-img{
display: flex;
align-items: flex-start;
}

.footer img{
width: 30%;
}

.footer p{
font-size: 18px;
padding-left: 1em;
}

img[alt=mastercard]{
width: 15%;
}
img[alt=chip]{
width: 25%;

}
img[alt=nubank]{
width: 15%;
}
}

@media (min-width: 700px){

.card{
display: flex;
font-family: Arial, Helvetica;
color: #fff;
height: 240px;
width: 400px;
display: table; 
margin: 8% auto; 

}
.container{
background-color: #820ad1;
padding: 1em;
border-radius: 4%;
width: 100%;
height: 100%;
box-shadow: #000;
}

.header{
height: 60%;
}
.box-img{
display: flex;
align-items: flex-start;
}

.footer img{
width: 35%;
}

.footer p{
font-size: 20px;
padding-left: 1em;
}

img[alt=mastercard]{
width: 15%;
}
img[alt=chip]{
width: 23%;

}
img[alt=nubank]{
width: 17%;
}
}

@media (min-width:1000px){
.card{
    display: flex;
    font-family: Arial, Helvetica;
    color: #fff;
    height: 240px;
    width: 420px;
    display: table; 
    margin: 8% auto; 

}
.container{
    background-color: #820ad1;
    padding: 1em;
    border-radius: 4%;
    width: 100%;
    height: 100%;
    box-shadow: #000;
}

.header{
    height: 55%;
}
.box-img{
    display: flex;
    align-items: flex-start;
}

.footer img{
    width: 20%;
}

.footer p{
    font-size: 25px;
    padding-left: 1em;
}

img[alt=mastercard]{
    width: 15%;
}
img[alt=chip]{
    width: 20%;
}
img[alt=nubank]{
width: 20%;
}
}
</style>