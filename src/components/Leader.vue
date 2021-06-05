<template>
  <div>
      <h1>Lab Director</h1>
      <v-row>
        <v-col cols="3">
          <v-avatar size="350">
            <v-img :src="photo"></v-img>
          </v-avatar>
        </v-col>
        <v-col cols="3">
          <div class="mt-3">
            <h2 class="mb-2">{{name}}</h2>
            <p v-for="t in titles" :key="t">{{t}}</p>
            <a :href="homepage">Homepage</a>
            <h4 class="mb-2 mt-3">Research Interests</h4>
            <ul>
                <li v-for="t in researchInterests" :key="t">{{t}}</li>
            </ul>
          </div>
        </v-col>
      </v-row>
  </div>
</template>

<script>
export default {
  data: () => ({
    name: 'Xi Yang (杨溪)',
    homepage: 'https://keepthinkingyx.github.io/Xi-Yang/',
    titles: ['Associate Professor', 'School of Artificial Intelligence, Jilin University'],
    researchInterests: ['Computer graphics', 'Deep learning', 'Human–computer interaction'],
    photo: 'img/yangxi.png'
  })
}
</script>
