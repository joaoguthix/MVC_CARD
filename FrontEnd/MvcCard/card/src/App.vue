<template>
  <div id="app">
    <Card/>
  </div>
</template>

<script>
import './assets/Image/mastercard_logo.png';
import './assets/Image/chip.png';
import './assets/Image/nubank_logo.png';
import Card from './components/CardComponent.vue'

export default {
  name: 'App',
  components: {
    Card
  }
}
</script>

<style>
*{
    margin: 0;
    padding: 0;
    box-sizing: border-box
}

</style>
