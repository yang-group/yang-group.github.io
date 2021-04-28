<template>
  <div>
      <h1>Lab Director</h1>
      <v-row class="d-flex justify-start">
        <v-col class="flex-grow-0">
            <v-img contain height=300 :src="photo"></v-img>
        </v-col>
        <v-col class="flex-grow-1">
            <h2>{{name}}</h2>
            <p v-for="t in titles" :key="t">{{t}}</p>
            <h3 class="mb-3">Research Interests</h3>
            <ul>
                <li v-for="t in researchInterests" :key="t">{{t}}</li>
            </ul>
        </v-col>
      </v-row>
  </div>
</template>

<script>
export default {
  data: () => ({
    name: 'Xi Yang (杨溪)',
    homepage: 'https://keepthinkingyx.github.io/Xi-Yang/',
    titles: ['Project Assistant Professor', 'The University of Tokyo', 'Jilin University'],
    researchInterests: ['Computer graphics', 'Deep learning', 'Human–computer interaction'],
    photo: 'img/yangxi.png'
  })
}
</script>
