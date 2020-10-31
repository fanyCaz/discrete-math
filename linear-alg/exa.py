import seaborn as sns
vuelos = sns.load_dataset("flights")
vuelos = vuelos.pivot("month","year","passengers")
ax = sns.heatmap(vuelos)